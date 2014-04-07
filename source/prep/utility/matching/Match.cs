namespace prep.utility.matching
{
  public class Match<ItemToMatch>
  {
    public static MatchFactory<ItemToMatch, AttributeReturnType> having_attribute<AttributeReturnType>(
      PropertyAccessor<ItemToMatch, AttributeReturnType> accessor)
    {
      return new MatchFactory<ItemToMatch, AttributeReturnType>(accessor);
    }
  }
}