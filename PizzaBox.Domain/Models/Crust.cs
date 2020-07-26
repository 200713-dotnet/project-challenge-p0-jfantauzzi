namespace PizzaBox.Domain.Models
{
  public class Crust
  {
    public string option { get; set; } //options normal, stuffed, deepdish



    //methods
    public double CrustCompute(Crust crust)
    {
      if (crust.option == "normal")
      {
        return 1.5;
      }
      else if (crust.option == "stuffed")
      {
        return 2.5;
      }
      else if (crust.option == "deepdish")
      {
        return 3;
      }
      else
        return 0;
    }

    //constructors
    public Crust(string op)
    {
      option = op;
    }

    public Crust()
    {
      option = "";
    }
    
  }
}