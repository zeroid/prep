namespace prep.utility.matching
{
  public static  class MatchExtensions
  {
    public static IMatchAn<ItemToMatch> or<ItemToMatch>(
      this IMatchAn<ItemToMatch> left,
      IMatchAn<ItemToMatch> right)
    {
      return new OrMatch<ItemToMatch>(left, right);
    }
  }
}