using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Store
  {
    public List<Order> Orders { get; set; }
    public static string Name { get; set; }

    public Order CreateOrder()
    {
      return new Order();
    }
  }
}