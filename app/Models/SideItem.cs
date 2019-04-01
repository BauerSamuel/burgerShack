using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  class SideItem : FoodItem
  {

    private string Size { get; set; }

    public SideItem(string name, string description, string price, List<string> ingredients, string size) : base(name, description, price, ingredients)
    {
      Size = size;
    }
  }
}