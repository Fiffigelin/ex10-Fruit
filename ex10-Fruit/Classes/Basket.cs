using System;
using System.Collections.Generic;
using System.Text;

namespace ex10_Fruit.Classes
{
  public class Basket
  {
    private readonly List<Fruit> _fruits = [];
    public IReadOnlyList<Fruit> Fruits => _fruits;

    public void AddFruit(Fruit fruit)
    {
      _fruits.Add(fruit);
    }

    public void RemoveFruit(Fruit fruit)
    {
      _fruits.Remove(fruit);
    }

    public int GetFruitCount()
    {
      return _fruits.Count;
    }

    public void AddMultibleFruits(List<Fruit> fruits)
    {
      if(fruits.Count <= 0)
      {
        return;
      }

       _fruits.AddRange(fruits);
    }

    public bool ContainsFruit(string name)
    {
      return _fruits.Any(fruit => fruit.Name == name);
    }
  }
}
