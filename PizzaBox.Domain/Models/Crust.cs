namespace PizzaBox.Domain.Models
{
  public class Crust
  {
    public string type { get; set; } //options normal, stuffed, deepdish


    //constructors
    public Crust()
    {

    } 
    //methods
    public double CrustCompute(Crust crust)
    {
      if (crust.type == "normal")
      {
        return 1.5;
      }
      else if (crust.type == "stuffed")
      {
        return 2.5;
      }
      else if (crust.type == "deepdish")
      {
        return 3;
      }
      else
        return 0;
    }
  }
}