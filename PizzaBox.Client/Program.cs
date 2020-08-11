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
      // Menu.UCounter = ;
      var user = new User();
      var store = new Store();
      var cou = new Counter(0);
      store.SetLocation();

      System.Console.WriteLine("\nSelect Log-In: ");
      System.Console.WriteLine("1. Store");
      System.Console.WriteLine("2. User");
      System.Console.WriteLine("3. Exit Application");
      System.Console.WriteLine("Input: ");
      int select0;
      int.TryParse(Console.ReadLine(), out select0);

      switch (select0)
      {
        case 1:
          //Store Menu Loop
          Menu.IsStoreLoop = true;
          do
          {

            store.PrintStoreStartMenu();
            int select;
            int.TryParse(Console.ReadLine(), out select);
            store.StoreMenuSelectionHandler(select, user);

          } while (Menu.IsStoreLoop);
          break;

        case 2:
          //Getting + Saving username
          Console.WriteLine("Enter Username: ");
          user.SetUserName(Console.ReadLine());

          //reading the xml coutner in, creating counter xml if it doesn't exist
          var fmg = new FileManager();
          try
          {
            cou = fmg.CounterRead();
          }
          catch (Exception ex)
          {
            fmg.WriteCounter(new Counter(0));
          }

          //saving username to incremented files
         // if (store.ReadLocation() == "NY")
          //{
          fmg.WriteUName(user.ReadUserName(), cou.counter);
          cou.counter += 1;
          fmg.WriteCounter(cou);
          //}
         // else if (store.ReadLocation() == "Buff"){

          //}
          Menu.UCounter = cou.counter;
          /* for (int i = 0; i < Menu.UCounter; i++)
           {
             if (user.ReadUserName() != fmg.UserNameRead(i))
             {
               continue;
             }
             else{

             }
           }*/
          //Main Menu Loop for Users
          Menu.IsUserLoop = true;
          do
          {

            user.PrintUserStartMenu();
            int select2;
            int.TryParse(Console.ReadLine(), out select2);
            user.UserMenuSelectionHandler(select2, store);

          } while (Menu.IsUserLoop);
          break;

        case 3:
          System.Console.WriteLine("Exiting Application...");
          return;
        default:
          System.Console.WriteLine("Invalid Option.");
          break;

      }
    }

  }
}
