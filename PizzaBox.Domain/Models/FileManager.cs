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

  //storing usernames
    public void WriteUName(string uname, int counter)
    {
      _path = $"data/usernames/{counter}.xml";
      var writer = new StreamWriter(_path);
      var xml = new XmlSerializer(typeof(string));

      xml.Serialize(writer, uname);
    }


    public string UserNameRead(int counter)
    { 

      _path = $@"data/usernames/{counter}.xml";
      
      var reader = new StreamReader(_path);
      var xml = new XmlSerializer(typeof(string));
      
      return xml.Deserialize(reader) as string;
      
    }

    //counter handler
    public void WriteCounter(Counter counter)
    {
      _path = $"data/usernames/counter.xml";
      var writer = new StreamWriter(_path);
      var xml = new XmlSerializer(typeof(Counter));

      xml.Serialize(writer, counter);
    }

    public Counter CounterRead()
    { 

      _path = $@"data/usernames/counter.xml";
      
      var reader = new StreamReader(_path);
      var xml = new XmlSerializer(typeof(Counter));
      
      return xml.Deserialize(reader) as Counter;
      
    }

  }
}