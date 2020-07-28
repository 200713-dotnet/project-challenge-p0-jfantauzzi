using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
  class Program
  {
    static void Main(string[] args)
    {

      Welcome();

      /*  creating and reading pizza
      var pr = new PizzaRepository();
      var pizza = new Pizza()
      {
        Name = "cheesy pizza",
        Crust = new Crust() { option = "deepdish"},
        Size = new Size() { option = "medium"},
        Toppings = new List<Topping> { new Topping("cheese")}
      }
      pr.Create(pizza);
      */

    }

    private static void Welcome()
    {
      Console.WriteLine("Welcome to Pizza Time!");

      //code to determine if user or store

      var user = new User();
      System.Console.WriteLine("Enter Username: ");
      user.SetUserName(Console.ReadLine());
      var store = new Store();
      store.SetLocation();
  
      //Main Menu Loop
      Menu.IsLoop = true;
      do
      {

        user.PrintUserStartMenu();
        int select;
        int.TryParse(Console.ReadLine(), out select);
        user.UserMenuSelectionHander(select, store);

      } while (Menu.IsLoop);

    }

  }
}
