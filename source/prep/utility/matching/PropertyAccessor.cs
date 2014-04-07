namespace prep.utility.matching
{
  public delegate AttributeType PropertyAccessor<in ItemToAccessAttributeFrom, out AttributeType>(
    ItemToAccessAttributeFrom item);
}