using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Models
{
  public class FileManager
  {
    private const string _path = @"data/orders.xml";

    public Order Read()
    {
      var reader = new StreamReader(_path);
      var xml = new XmlSerializer(typeof(Order));

      return xml.Deserialize(reader) as Order;
    }

    public void Write(Order order)
    {
      var writer = new StreamWriter(_path);
      var xml = new XmlSerializer(typeof(Order));

      xml.Serialize(writer, order);
    }

  }
}