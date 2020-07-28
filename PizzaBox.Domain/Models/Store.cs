using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Store
  {
    public List<Order> Orders { get; set; }
    public static string StoreName { get; set; }


    public void SetLocation()
    {
      System.Console.WriteLine("Pick a Store Location:");
      System.Console.WriteLine("1. New York");
      System.Console.WriteLine("2. Buffalo\n");
      System.Console.WriteLine("Pick an Option: ");
      int select;
      int.TryParse(Console.ReadLine(), out select);

      switch (select)
      {
        case 1:
          StoreName = "NY";
          break;
        case 2:
          StoreName = "Buff";
          break;
        default:
          System.Console.WriteLine("Invalid Input");
          break;
      }
      return;
    }

    public string ReadLocation()
    {
      return StoreName;
    }

    public Order CreateOrder()
    {
      return new Order();
    }

    public Store()
    {
      StoreName = "NY";
    }
  }
}