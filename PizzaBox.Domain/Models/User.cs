using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public List<Order> Orders { get; set; }
    // public Name Name { get; set; }
    public static string UserName { get; set; }

    //Methods
    public void PrintUserStartMenu()
    {
      Console.WriteLine($"Welcome {UserName}!\n");
      Console.WriteLine("1: Make an Order");
      Console.WriteLine("2: View Order History");
      Console.WriteLine("3: Select Location.");
      Console.WriteLine("4: Exit Application\n");
      Console.WriteLine("Input: ");
    }

    public void UserMenuSelectionHandler(int input, Store st) //main menu for users
    {

      switch (input)
      {
        case 1:
          OrderCreation(st);
          break;
        case 2:
          var fmr = new FileManager();
          var or = new Order();
          //or.PrintHistory();
          or.PrintOrder(fmr.Read(st.ReadLocation(), UserName));
          break;
        case 3:
          st.SetLocation();
          break;
        case 4:
          Menu.IsUserLoop = false;
          Console.WriteLine("Goodbye!");
          break;
        default:
          System.Console.WriteLine("Invalid Option.\n");
          break;
      }
    }

    public void SetUserName(string str)
    {
      UserName = str;
    }

    public string ReadUserName()
    {
      return UserName;
    }

    public void OrderCreation(Store st) //creates order
    {
      Order currentOrder = new Order();
      var orderingLoop = true;
      do
      {
        Console.WriteLine("\nPick a Pizza:");
        Console.WriteLine("1: Standard Cheese");
        Console.WriteLine("2: The Deep Little");
        Console.WriteLine("3: The Pizza Timer");
        Console.WriteLine("4: Add a Custom Pizza");
        System.Console.WriteLine("5. Finish Order\n");
        Console.WriteLine("Input: ");
        int select;
        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1: //creates/adds to current order a pizza object with toppings(cheese), normal crust, medium size


            List<Topping> SCtoppings = new List<Topping> { new Topping("cheese") };
            currentOrder.AddPizzaToOrder(SCtoppings, new Crust("normal"), new Size("medium"), "Standard Cheese");
            Console.WriteLine("Standard Cheese added to your order.\n");
            break;

          case 2: //creates/adds to current order a pizza object with toppings(cheese, pepperoni), deepdish crust, small size
            List<Topping> DLtoppings = new List<Topping> { new Topping("cheese"), new Topping("pepperoni") };
            currentOrder.AddPizzaToOrder(DLtoppings, new Crust("deepdish"), new Size("small"), "Deep Little");
            Console.WriteLine("Standard Pepperoni added to your order.\n");
            break;

          case 3: //creates/adds to current order a pizza with many toppings(cheese, sausage, peppers, onions), stuffed crust, large size
            List<Topping> PTtoppings = new List<Topping> { new Topping("cheese"), new Topping("sausage"), new Topping("peppers"), new Topping("onions") };
            currentOrder.AddPizzaToOrder(PTtoppings, new Crust("stuffed"), new Size("large"), "Pizza Timer");
            Console.WriteLine("Pizza Timer added to your order.\n");
            break;

          case 4: //creating a custom pizza object and adding it to the current order

            //initializing toppings list, crust object, size object
            List<Topping> CUStoppings = new List<Topping>() { new Topping("cheese") };
            Crust CUScrust = new Crust();
            Size CUSsize = new Size("");

            //Picking size
            Console.WriteLine("Pick your Size!");
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
            Console.WriteLine("Pick the type of Crust you'd like!");
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
            bool toppingLoop = true;
            var toppingCount = 0; //going to limit toppings to 5
            do
            {
              if (toppingCount < 5)
              {
                Console.WriteLine("Add your Toppings! Select 1-6 to add a topping. Select 7 when you're done.");
                Console.WriteLine("1. Add Extra Cheese.");
                Console.WriteLine("2. Add Pepperoni.");
                Console.WriteLine("3. Add Sausage.");
                Console.WriteLine("4. Add Ham.");
                Console.WriteLine("5. Add Peppers.");
                Console.WriteLine("6. Add Onions.");
                Console.WriteLine("7. I'm done!\n");

                int toppingPick;
                int.TryParse(Console.ReadLine(), out toppingPick);

                switch (toppingPick)
                {
                  case 1:
                    CUStoppings.Add(new Topping("extra cheese"));
                    toppingCount += 1;
                    break;
                  case 2:
                    CUStoppings.Add(new Topping("pepperoni"));
                    toppingCount += 1;
                    break;
                  case 3:
                    CUStoppings.Add(new Topping("sausage"));
                    toppingCount += 1;
                    break;
                  case 4:
                    CUStoppings.Add(new Topping("ham"));
                    toppingCount += 1;
                    break;
                  case 5:
                    CUStoppings.Add(new Topping("peppers"));
                    toppingCount += 1;
                    break;
                  case 6:
                    CUStoppings.Add(new Topping("onions"));
                    toppingCount += 1;
                    break;
                  case 7:
                    toppingLoop = false;
                    break;
                  default:
                    Console.WriteLine("Not an option.");
                    break;
                }
              }
              else
              {
                toppingLoop = false;
                System.Console.WriteLine("You've reached the limit of 5 toppings!");
              }
            } while (toppingLoop);

            //creating pizza, add to order
            currentOrder.AddPizzaToOrder(CUStoppings, CUScrust, CUSsize, "Custom Pizza");
            break;

          //Finished order, write it to xml file
          case 5: 
            System.Console.WriteLine("Finishing up your Order.");
            var fmw = new FileManager();
            fmw.Write(currentOrder, st.ReadLocation(), UserName);
            orderingLoop = false;
            break;
        }

      } while (orderingLoop);

      currentOrder.PrintOrder(currentOrder);
    }

  }

}