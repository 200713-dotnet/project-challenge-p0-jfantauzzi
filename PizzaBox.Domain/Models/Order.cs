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
    public void AddPizzaToOrder(List<Topping> toppings, Crust crust, Size size, string name)
    {
      Pizzas.Add(new Pizza(toppings, crust, size, name));
    }

    public void PrintOrder(Order or)
    {
      Console.WriteLine("\nYour order:");
      foreach (var p in or.Pizzas)
      {

        Console.WriteLine($"{p.Name} - {p.ComputePricePizza(p)}");
        if (p.Name == "Custom Pizza")
        {
          Console.WriteLine($" {p.Crust.option}");
          Console.WriteLine($" {p.Size.option}");
          foreach(var t in p.Toppings)
          {
            System.Console.WriteLine($" {t.option} - {t.ToppingCompute(t)}");
          }
        
        }
      }
      System.Console.WriteLine($"Order Total - {or.TotalPrice()}\n");
    }

    //public void PrintHistory();

    public double TotalPrice()
    {
      double OrderPrice = 0;
      foreach (var pizza in Pizzas)
      {
        OrderPrice += pizza.ComputePricePizza(pizza);
      }

      Price = OrderPrice;
      return OrderPrice;
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