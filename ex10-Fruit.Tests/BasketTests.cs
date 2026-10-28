using ex10_Fruit.Classes;

namespace ex10_Fruit.Tests
{
  public class BasketTests
  {
    [Fact]
    public void AddFruit_ShouldIncreaseFruitCount()
    {
      // Arrange
      Basket basket = new();
      Fruit apple = new("Apple");

      // Act
      basket.AddFruit(apple);

      //Assert
      Assert.Equal(1, basket.GetFruitCount());
    }

    [Fact]
    public void RemoveFruit_ShouldDecreaseFruitCount()
    {
      // Arrange
      Basket basket = new();
      Fruit apple = new("Apple");
      Fruit banana = new("Banana");
      Fruit orange = new("Orange");
      basket.AddFruit(apple);
      basket.AddFruit(banana);
      basket.AddFruit(orange);

      // Act
      basket.RemoveFruit(apple);

      //Assert
      Assert.Equal(2, basket.GetFruitCount());
    }

    [Fact]
    public void AddFruit_AsAListWithFruits()
    {
      // Arrange
      Basket basket = new();
      List<Fruit> fruits = [
        new Fruit("Apple"),
        new Fruit("Banana"),
        new Fruit("Orange"),
       ];

      // Act
      basket.AddMultibleFruits(fruits);

      //Assert
      Assert.Equal(3, basket.GetFruitCount());
    }
  }
}
