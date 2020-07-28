using System;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Models
{
  public class FileManager
  {
    private static string _path = @"data/orders.xml";


    public Order Read(string storename, string username)
    {
      try{
      _path = $"data/{storename}/{username}_orders.xml";

      var reader = new StreamReader(_path);
      var xml = new XmlSerializer(typeof(Order));
      
      return xml.Deserialize(reader) as Order;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Oops, an error! You likely haven't ordered from this location previously.");
      }
      return new Order();
    }

    public void Write(Order order, string storename, string username)
    {
      _path = $"data/{storename}/{username}_orders.xml";
      var writer = new StreamWriter(_path);
      var xml = new XmlSerializer(typeof(Order));

      xml.Serialize(writer, order);
    }

  }
}