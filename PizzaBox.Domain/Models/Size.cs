namespace PizzaBox.Domain.Models
{
  public class Size
  {
    public string option { get; set; } //options small, medium, large

    public Size()
    {

    }

    //method
     public double SizeCompute(Size size)
    {
      if (size.option == "small")
      {
        return 3;
      }
      else if (size.option == "medium")
      {
        return 4;
      }
      else if (size.option == "large")
      {
        return 5;
      }
      else
        return 0;
    }
  }
}