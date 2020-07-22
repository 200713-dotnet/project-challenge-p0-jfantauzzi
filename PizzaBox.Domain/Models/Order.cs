using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public List<Pizza> Pizzas { get; set; }
    public DateTime DateOrdered { get; set; }

    public void CreatePizza()
    {
      Pizzas.Add(new Pizza());
    }

    public double TotalPrice()
    {
      //add up each pizza price duh
      return 0;
    }

  }
}