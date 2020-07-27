using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public List<Topping> Toppings { get; set; }
    public Crust Crust { get; set; }
    public Size Size { get; set; }

    public string Name { get; set; }
    public double Price { get; set; }




    //methods
    public double ComputePricePizza(Pizza pizza)
    {
      double PizzaPrice = 0;
      PizzaPrice += pizza.Crust.CrustCompute(pizza.Crust);
      PizzaPrice += pizza.Size.SizeCompute(pizza.Size);
      foreach (var topping in pizza.Toppings)
      {
        PizzaPrice += topping.ToppingCompute(topping);
      }

      pizza.Price = PizzaPrice;
      return PizzaPrice;
    }

    //constructors
  /*  public Pizza()
    {
      Crust = new Crust();
      Size = new Size();
      Toppings = new List<Topping>();
    } */
    public Pizza()
    {
      
    }

    public Pizza(List<Topping> toppings, Crust crust, Size size, string name)
    {
      Crust = crust;
      Size = size;
      Name = name;
      Toppings = new List<Topping>();
      Toppings.AddRange(toppings);

    }

  }
}