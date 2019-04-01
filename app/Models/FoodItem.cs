using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  abstract class FoodItem : Item
  {

    private List<string> Ingredients { get; set; }

    public FoodItem(string name, string description, string price, List<string> ingredients) : base(name, description, price)
    {
      Ingredients = ingredients;
    }
  }
}