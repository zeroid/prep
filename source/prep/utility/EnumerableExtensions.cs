﻿using System.Collections.Generic;
using prep.utility.matching;

namespace prep.utility
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      foreach (var item in items) yield return item;
    }

    public static IEnumerable<T> all_items_matching<T>(this IEnumerable<T> items,
      Condition<T> condition)
    {
      foreach (var item in items)
      {
        if (condition(item)) yield return item;
      }
    }

    public static IEnumerable<T> all_items_matching<T>(this IEnumerable<T> items,
      IMatchAn<T> specification)
    {
      return items.all_items_matching(specification.matches);
    }
  }
}