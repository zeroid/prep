namespace prep.utility.matching
{
  public class ConditionalMatch<ItemToMatch> : IMatchAn<ItemToMatch>
  {
    Condition<ItemToMatch> condition;

    public ConditionalMatch(Condition<ItemToMatch> condition)
    {
      this.condition = condition;
    }

    public bool matches(ItemToMatch item)
    {
      return condition(item);
    }
  }
}