using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public List<Pizza> Pizzas { get; set; }
    public DateTime DateOrdered { get; set; }
    public double Price { get; set; }



    //methods
    public void AddPizzaToOrder(List<Topping> toppings, Crust crust, Size size)
    {
      Pizzas.Add(new Pizza(toppings, crust, size));
    }

    public void TotalPrice()
    {
      double OrderPrice = 0;
      foreach (var pizza in Pizzas)
      {
        OrderPrice += pizza.ComputePricePizza(pizza);
      }
      
      Price = OrderPrice;
      return;
    }

    //constructors
    public Order()
    {
      Pizzas = new List<Pizza>();
    }



  }
}