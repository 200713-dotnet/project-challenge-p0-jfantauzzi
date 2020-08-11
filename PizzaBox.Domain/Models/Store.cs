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
      Console.WriteLine($"\nWelcome {StoreName} Admin!\n");
      Console.WriteLine("Select an Option:");
      Console.WriteLine("1. View Order History");
      Console.WriteLine("2. View Sales");
      Console.WriteLine("3. Exit Application");
      Console.WriteLine("Input: ");
    }

    public void StoreMenuSelectionHandler(int input, User us)
    {
      switch (input)
      {
        case 1:
          var fmr = new FileManager();
          var or = new Order();
          var co = new Counter();
          try
          {
            co = fmr.CounterRead();
            Menu.UCounter = co.counter;
            for (int i = 0; i < Menu.UCounter; i++)
            {
              or.PrintOrder(fmr.Read(StoreName, fmr.UserNameRead(i)));
            }
          }
          catch (Exception ex)
          {
            System.Console.WriteLine("Looks like no one has ordered from you yet");
          }



          //or.PrintOrder(fmr.Read(StoreName, us.ReadUserName()));
          break;
        case 2:
          double Revanue = 0;

          var fms = new FileManager();
          var ord = new Order();
          var cou = new Counter();
          List<Order> ords = new List<Order>();
          try
          {
            co = fms.CounterRead();
            Menu.UCounter = co.counter;

            for (int i = 0; i < Menu.UCounter; i++)
            {
              Revanue += fms.Read(StoreName, fms.UserNameRead(i)).TotalPrice();
            }
          }
          catch (Exception ex)
          {
            System.Console.WriteLine("Looks like no one has ordered from you yet");
          }

          Console.WriteLine($"Revenue: {Revanue}"); //need a db
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