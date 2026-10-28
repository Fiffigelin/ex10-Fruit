using ex10_Fruit.Classes;

namespace ex10_Fruit.Tests
{
  public class BasketTests
  {
    [Fact]
    public void AddFruit_ShouldIncrease_FruitCount()
    {
      // Arrange
      Basket basket = new();
      Fruit apple = new("Apple");

      // Act
      basket.AddFruit(apple);

      //Assert
      Assert.Equal(1, basket.GetFruitCount());
    }
  }
}
