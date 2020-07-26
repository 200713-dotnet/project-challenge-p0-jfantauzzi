using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

    private static void Welcome()
    { 
      var user = new User();
      //var store = new Store();
      Console.WriteLine("Welcome to Pizza Time!");
      var loop = true;
      //code to determine if user or store
      do
      {
      user.PrintUserStartMenu();

      int select;
      int.TryParse(Console.ReadLine(), out select);
      user.UserMenuSelectionHander(select);
      
      } while(loop);
      
    }

  }
}
