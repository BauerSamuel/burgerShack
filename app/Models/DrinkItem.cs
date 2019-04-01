using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  abstract class DrinkItem : Item
  {
    private string Size { get; set; }
    public DrinkItem(string name, string description, decimal price, string size) : base(name, description, price)
    {
      Size = size;
    }
  }
}