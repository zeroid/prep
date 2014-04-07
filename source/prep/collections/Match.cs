using System;

namespace prep.collections
{
  public delegate ProductionStudio GetTheProductionStudio(Movie movie);
  public class Match<ItemToMatch>
  {
    public static void with_attribute(GetTheProductionStudio accessor)
    {
      throw new NotImplementedException();
    }
  }

  public static class Blah
  {
    
  }
}