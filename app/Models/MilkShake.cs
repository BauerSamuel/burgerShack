using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  class MilkShake : DrinkItem
  {

    private List<string> Ingredients { get; set; }

    public MilkShake(string name, string description, string price, string size, List<string> ingredients) : base(name, description, price, size)
    {
      Ingredients = ingredients;
    }
  }
}