using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  class SideItem : FoodItem
  {

    private string Size { get; set; } = "small";

    public SideItem(string name, string description, decimal price, List<string> ingredients, string size) : base(name, description, price, ingredients)
    {
      Size = size;
    }
  }
}