namespace burgerShack.Models
{
  abstract class Item
  {
    private string Name { get; set; }
    private string Description { get; set; }
    private string Price { get; set; }

    public Item(string name, string description, string price)
    {
      Name = name;
      Description = description;
      Price = price;
    }
  }
}