namespace PizzaBox.Domain.Models
{
  public class Counter
  {
    public int counter { get; set; }
    public int counterBuf { get; set; }

    public Counter()
    {
      
    }
    public Counter(int co)
    {
      counter = co;
    }
  }


}