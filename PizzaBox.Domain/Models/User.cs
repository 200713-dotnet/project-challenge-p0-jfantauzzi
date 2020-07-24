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
      Console.WriteLine("1: Start Order");
      Console.WriteLine("2: View Order History");
      Console.WriteLine("3: Set Store Location");
      Console.WriteLine("4: Exit Application\n");
      Console.WriteLine("Input: ");
    }
    public void UserMenuSelectionHander(int input)
    {
      switch (input)
      {
        case 1:
          
      }
    }
  }

}