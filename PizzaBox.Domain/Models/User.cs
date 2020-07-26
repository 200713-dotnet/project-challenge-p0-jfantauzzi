using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public List<Order> Orders { get; set; }
    // public Name Name { get; set; }
    public string Name { get; set; }

    //Methods
    public void PrintUserStartMenu()
    {
      Console.WriteLine($"Welcome {Name}!\n");
      Console.WriteLine("1: Make an Order");
      Console.WriteLine("2: View Order History");
      Console.WriteLine("3: Set Store Location");
      Console.WriteLine("4: Exit Application\n");
      Console.WriteLine("Input: ");
    }
    public void UserMenuSelectionHander(int input) //main menu for users
    {
      switch (input)
      {
        case 1:
          OrderCreation();
          break;
        case 2:
          Console.WriteLine("Under Construction! Please try another option.");
          break;
        case 3:
          Console.WriteLine("Under Construction! Please try another option.");
          break;
        case 4:
          Console.WriteLine("Goodbye!");
          break;
      }
    }

    public void OrderCreation() //creates order
    {
      Order currentOrder = new Order();
      var orderingLoop = true;
      do
      {
        Console.WriteLine("\nPick a Pizza:");
        Console.WriteLine("1: Standard Cheese");
        Console.WriteLine("2: The Deep Little");
        Console.WriteLine("3: The Pizza Timer");
        Console.WriteLine("4: Custom Pizza\n");
        Console.WriteLine("Input: ");
        int select;
        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1: //creates/adds to current order a pizza object with toppings(cheese), normal crust, medium size
            List<Topping> SCtoppings = new List<Topping> {new Topping("cheese")};
            currentOrder.AddPizzaToOrder(SCtoppings, new Crust("normal"), new Size("medium"));
            Console.WriteLine("Standard Cheese added to your order.\n");
            break;

          case 2: //creates/adds to current order a pizza object with toppings(cheese, pepperoni), deepdish crust, small size
            List<Topping> DEtoppings = new List<Topping> { new Topping("cheese"), new Topping("pepperoni") };
            currentOrder.AddPizzaToOrder(DEtoppings, new Crust("deepdish"), new Size("small"));
            Console.WriteLine("Standard Pepperoni added to your order.\n");
            break;

          case 3: //creates/adds to current order a pizza with many toppings(cheese, sausage, peppers, onions), stuffed crust, large size
            List<Topping> PTtoppings = new List<Topping> { new Topping("cheese"), new Topping("sausage"), new Topping("peppers"), new Topping("onions") };
            currentOrder.AddPizzaToOrder(PTtoppings, new Crust("stuffed"), new Size("large"));
            Console.WriteLine("Pizza Timer added to your order.\n");
            break;

          case 4: //creating a custom pizza object and adding it to the current order

            //initializing toppings list, crust object, size object
            List<Topping> CUStoppings = new List<Topping>();
            Crust CUScrust = new Crust();
            Size CUSsize = new Size("");

            //Picking size
            Console.WriteLine("Pick your Size!\n");
            Console.WriteLine("1. Small");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Large\n");
            int sizePick;
            int.TryParse(Console.ReadLine(), out sizePick);
            // need loop cause peopel aint gonna type right thing...
            switch (sizePick)
            {
              case 1:
                CUSsize.option = "small";
                break;
              case 2:
                CUSsize.option = "medium";
                break;
              case 3:
                CUSsize.option = "large";
                break;
              default:
                System.Console.WriteLine("That's not an option.");
                break;
            }

            //Picking crust
            Console.WriteLine("Pick the type of Crust you'd like!\n");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Stuffed");
            Console.WriteLine("3. Deepdish\n");
            int crustPick;
            int.TryParse(Console.ReadLine(), out crustPick);
            // need loop cause people aint gonna type right thing...
            switch (crustPick)
            {
              case 1:
                CUScrust.option = "normal";
                break;
              case 2:
                CUScrust.option = "stuffed";
                break;
              case 3:
                CUScrust.option = "deepdish";
                break;
              default:
                System.Console.WriteLine("That's not an option.");
                break;
            }

          //Picking Toppings
            Console.WriteLine("Pick the type of Crust you'd like!\n");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Stuffed");
            Console.WriteLine("3. Deepdish\n");
            int toppingPick;
            int.TryParse(Console.ReadLine(), out toppingPick);


            break;
        }

      } while (orderingLoop);
    }

  }

}