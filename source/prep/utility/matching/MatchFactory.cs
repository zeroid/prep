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
      throw new System.NotImplementedException();
    }
  }
}