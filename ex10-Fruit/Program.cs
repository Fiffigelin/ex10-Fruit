using ex10_Fruit.Classes;

namespace ex10_Fruit
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Basket basket = new();
      basket.AddFruit(new Fruit("Mango"));
      List<Fruit> fruits = [
        new Fruit("Apple"),
        new Fruit("Banana"),
        new Fruit("Orange"),
        ];

      basket.AddMultibleFruits(fruits);
      foreach(Fruit fruit in basket.Fruits)
      {
        Console.WriteLine(fruit.Name);
      }
    }
  }
}
