using System.Collections.Generic;
using PizzaBox.Domain.Models;
using Xunit;

namespace Pizzabox.Testing.Tests
{
  public class OrderTest
  {
    Topping top1 = new Topping("ch");
    Topping top2 = new Topping("pep");
    Crust Cr1 = new Crust("normal");
    Size Si1 = new Size("small");

    [Theory]
    [InlineData( top1, Cr1, Si1)]
    [InlineData( top2, Cr2, Si2)]

    public void Test_AddPizzaToOrder(Topping t, Crust c, Size s, string name)
    {
      var sut = new Order();
      Crust crust = c;
      Size size = s;
      List<Topping> toppings = new List<Topping> {t};

    }
  }
}