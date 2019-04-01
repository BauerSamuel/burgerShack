using System;
using System.Collections.Generic;
using burgerShack.Models;

namespace burgerShack
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Hi welcome to Burger Shack. Can I help you?");
      string irelevent = Console.ReadLine();
      Menu menu = new Menu();
      string rawChoice = "";
      decimal total = 0.00m;
      List<string> Orders = new List<string>();
      while (rawChoice.ToLower() != "c")
      {
        int choice = 0;
        Console.Clear();
        menu.ShowMenu();
        foreach (var order in Orders)
        {
          Console.WriteLine($"\n{order}");
        }
        Console.WriteLine($"\nTotal: {total}");
        Console.WriteLine("Choose item, or enter (c) to checkout: ");
        rawChoice = Console.ReadLine();
        if (Int32.TryParse(rawChoice, out choice) || menu.Validate(choice - 1))
        {
          total += menu.MenuItems[choice - 1].Price;
          Orders.Add(menu.MenuItems[choice - 1].Name);
        }
        else if (rawChoice == "c")
        {
          continue;
        }
        else
        {
          Console.WriteLine("Not recognized, sorry. Try again.");
        }
      }
      Console.WriteLine($"Your total is: {total}, cash or card?");
      string method = Console.ReadLine();
      if (method.ToLower() == "cash")
      {
        Console.WriteLine($"Thank you for paying. Wait for your number to be called, should be about {Orders.Count} minutes.");
      }
      else
      {
        Console.WriteLine($"I hope you said card, swipe it here. Now sign here. Thank you, please wait over there for your number to be called, should be {Orders.Count} minutes.");
      }
    }
  }
}
