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

      var store = new Store();
      store.SetLocation();

      //Store Menu Loop
      Menu.IsStoreLoop = true;
      do{

        store.PrintStoreStartMenu();
        int select;
        int.TryParse(Console.ReadLine(), out select);
        store.StoreMenuSelectionHandler(select, user);

      } while (Menu.IsStoreLoop);

      //Main User Menu Loop
      Console.WriteLine("Enter Username: ");
      user.SetUserName(Console.ReadLine());

      Menu.IsUserLoop = true;
      do
      {

        user.PrintUserStartMenu();
        int select2;
        int.TryParse(Console.ReadLine(), out select2);
        user.UserMenuSelectionHandler(select2, store);

      } while (Menu.IsUserLoop);

    }

  }
}
