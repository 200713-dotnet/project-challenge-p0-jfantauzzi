using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Topping
  {
    public string option { get; set; } //options cheese, pepperoni, ham, peppers

    public double ToppingCompute(Topping topping)
    {
      if (topping.option == "pepperoni")
      {
        return 0.5;
      }
      else if (topping.option == "ham")
      {
        return 1.5;
      }
      else if (topping.option == "peppers")
      {
        return 1.0;
      }
      else if (topping.option == "sausage")
      {
        return 1.5;
      }
      else if (topping.option == "onions")
      {
        return 0.5;
      }
      else if (topping.option == "extra cheese")
      {
        return 0.25;
      }
      else
        return 0;
    }

    public Topping(string op)
    {
      option = op;
    }

    public Topping()
    {
      option = "";
    }

  }
}