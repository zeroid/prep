using prep.collections;

namespace prep.utility.matching
{
  public class MatchFactory<ItemToMatch, AttributeReturnType>
  {
    PropertyAccessor<ItemToMatch, AttributeReturnType> accessor;

    public MatchFactory(PropertyAccessor<ItemToMatch, AttributeReturnType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToMatch> equal_to(AttributeReturnType value)
    {
      return new ConditionalMatch<ItemToMatch>(x => accessor(x).Equals(value));
    }

    public IMatchAn<ItemToMatch> equal_to_any(params AttributeReturnType[] possible_values)
    {
        IMatchAn<ItemToMatch> matcher = null;
        foreach (var possible_value in possible_values)
        {
            if (matcher == null)
            {
                matcher = equal_to(possible_values[0]);
            }
            else
            {
                matcher = matcher.or(equal_to(possible_value));
            }
        }
        return matcher;
    }
  }
}