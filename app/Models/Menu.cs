using System.Collections.Generic;
using System;

namespace burgerShack.Models
{
  class Menu
  {
    public List<Item> MenuItems { get; set; }

    public Menu()
    {

      //Build the menu

      FoodItem Hamburger = new FoodItem("Hamburger", "A regular old hamburger.", 2.50m, new List<string>() { "bread", "meat", "ketchup" });
      FoodItem Cheeseburger = new FoodItem("Cheeseburger", "A normal cheeseburger.", 3.00m, new List<string>() { "bread", "meat", "cheese", "ketchup" });
      FoodItem ChickenSand = new FoodItem("Chicken Sandwich", "A plain old crispy chicken sandwich", 3.50m, new List<string>() { "bread", "fried chicken", "mayonnaise" });
      SideItem SmlFries = new SideItem("Small Fries", "Lightly salted fried potato slices.", 1.00m, new List<string>() { "potatoe", "oil", "salt" }, "small");
      SideItem MedFries = new SideItem("Medium Fries", "Lightly salted fried potato slices.", 1.50m, new List<string>() { "potatoe", "oil", "salt" }, "medium");
      SideItem LrgFries = new SideItem("Large Fries", "Lightly salted fried potato slices.", 2.00m, new List<string>() { "potatoe", "oil", "salt" }, "large");
      SideItem SmlTots = new SideItem("Small Tots", "Perfect batch of Idaho potatoe tots.", 1.00m, new List<string>() { "potatoe", "oil, salt" }, "small");
      SideItem LrgTots = new SideItem("Large Tots", "Perfect batch of Idaho potatoe tots.", 2.00m, new List<string>() { "potatoe", "oil, salt" }, "large");
      FountainDrink SmlRootBeer = new FountainDrink("Small Rootbeer", "Just a beverage.", 2.00m, "small");
      FountainDrink MedRootBeer = new FountainDrink("Medium Rootbeer", "Just a beverage.", 2.50m, "medium");
      FountainDrink LrgRootBeer = new FountainDrink("Large Rootbeer", "Just a beverage.", 3.00m, "large");
      FountainDrink SmlCola = new FountainDrink("Small Cola", "Just a beverage.", 2.00m, "small");
      FountainDrink MedCola = new FountainDrink("Medium Cola", "Just a beverage.", 2.50m, "medium");
      FountainDrink LrgCola = new FountainDrink("Large Cola", "Just a beverage.", 3.00m, "large");
      FountainDrink SmlLemonade = new FountainDrink("Small Lemonade", "Just a beverage.", 1.50m, "small");
      FountainDrink MedLemonade = new FountainDrink("Medium Lemonade", "Just a beverage.", 2.00m, "medium");
      FountainDrink LargeLemonade = new FountainDrink("Large Lemonade", "Just a beverage.", 2.50m, "large");
      FountainDrink Water = new FountainDrink("Water", "Filtered water.", 0.00m, "none");
      MilkShake SmlVan = new MilkShake("Small Vanilla", "Hand-Churned Milkshake", 2.00m, "small", new List<string>() { "ice cream", "milk", "shake" });
      MilkShake LrgVan = new MilkShake("Large Vanilla", "Hand-Churned Milkshake", 4.00m, "large", new List<string>() { "ice cream", "milk", "shake" });
      MilkShake SmlChoc = new MilkShake("Small Chocolate", "Hand-Churned Milkshake", 4.00m, "small", new List<string>() { "ice cream", "milk", "shake", "chocolate" });
      MilkShake LrgChoc = new MilkShake("Large Chocolate", "Hand-Churned Milkshake", 4.00m, "large", new List<string>() { "ice cream", "milk", "shake", "chocolate" });

      //build the menu more.

      List<Item> Items = new List<Item>()
      {
        Hamburger,
        Cheeseburger,
        ChickenSand,
        SmlFries,
        MedFries,
        LrgFries,
        SmlTots,
        LrgTots,
        SmlRootBeer,
        MedRootBeer,
        LrgRootBeer,
        SmlCola,
        MedCola,
        LrgCola,
        SmlLemonade,
        MedLemonade,
        LargeLemonade,
        Water,
        SmlVan,
        LrgVan,
        SmlChoc,
        LrgChoc
      };
      MenuItems = Items;
    }

    internal bool Validate(int v)
    {
      if (v > -1 && v < MenuItems.Count)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public void ShowMenu()
    {
      Console.WriteLine(@"
ITEM#     PRICE      NAME
---------------------------------------------------
      ");
      for (int i = 0; i < MenuItems.Count; i++)
      {
        var item = MenuItems[i];
        Console.WriteLine($@"{i + 1}    ${item.Price}         {item.Name}");
      }
      return;
    }
  }
}