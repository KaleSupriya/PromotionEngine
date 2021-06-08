namespace PromotionEngine
{
  public class Product
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public Product(string name, int quantity, int price = 0)
    {
      Name = name;
      Price = price;
      Quantity = quantity;
    }
  }
}
