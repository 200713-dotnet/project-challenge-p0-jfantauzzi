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

    public void AddPizza(Pizza pizza)
    {
      Pizzas.Add(pizza);
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

    /*public void OrderCreation()
    {
      var orderingLoop = true;
      do
      {

        Console.WriteLine("1: Standard Cheese");
        Console.WriteLine("2: Standard Pepperoni");
        Console.WriteLine("3: The Pizza Timer");
        Console.WriteLine("4: Custom Pizza\n");
        Console.WriteLine("Input: ");
        int select;
        int.TryParse(Console.ReadLine(), out select);

        switch(select)
        {
          case 1:
            currentOrder.AddPizzaToOrder()
        }

      } while (orderingLoop)
    }*/


    //constructors
    public Order()
    {
      Pizzas = new List<Pizza>();
    }



  }
}