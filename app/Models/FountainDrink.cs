using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  class FountainDrink : DrinkItem
  {

    public bool Ice { get; set; } = true;

    public FountainDrink(string name, string description, decimal price, string size) : base(name, description, price, size)
    {

    }

    public void changeIce()
    {
      Ice = !Ice;
      return;
    }
  }
}