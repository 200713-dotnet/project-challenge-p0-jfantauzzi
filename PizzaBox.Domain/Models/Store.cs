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
      System.Console.WriteLine("Input: ");
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

    public void PrintStoreStartMenu()
    {
      System.Console.WriteLine($"Welcome {StoreName} Admin!\n");
      System.Console.WriteLine("Select an Option:");
      System.Console.WriteLine("1. View Order History");
      System.Console.WriteLine("2. View Sales");
      System.Console.WriteLine("3. Exit Application");
    }

    public void StoreMenuSelectionHandler(int input, User us)
    {
      switch (input)
      {
        case 1:
          var fmr = new FileManager();
          var or = new Order();
          //or.PrintHistory();
          or.PrintOrder(fmr.Read(ReadLocation(), us.ReadUserName()));
          break;
        case 2:
          System.Console.WriteLine("Under Construction! We'll get back to you."); //need a db
          break;
        case 3:
          Menu.IsStoreLoop = false;
          System.Console.WriteLine("Exiting Application...");
          break;
        default:
          System.Console.WriteLine("Invalid Option");
          break;
      }

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