using System;
using System.Collections.Generic;
using domain = PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class Repository
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public void Create(domain.Pizza pizza)
    {
      var newPizza = new Pizza(); //gonna be storing's pizza after ef scaffold

      newPizza.Crust = new Crust() { option = pizza.Crust.option };
      newPizza.Size = new Size() { option = pizza.Size.option };
      newPizza.Name = pizza.Name;
      //newPizza.DateModified = DateTime.Now; //not really for model information
      //newPizza.Active = true; //not really for model information
      //newPizza.UserModified = Identity.Hash;

      _db.Pizza.Add(newPizza); //git add
      _db.SaveChanges(); //git commit
    }

    public IEnumerable<domain.Pizza> ReadAll() //or list
    {
      var domainPizzaList = new List<domain.Pizza>();
      foreach (var item in _db.Pizza.ToList())
      {
        domainPizzaList.Add(new domain.Pizza()
        {
          Crust = new domain.Crust() { option = item.Crust.option },
          Size = new domain.Size() { option = item.Size.option },
          Toppings = new List<domain.Topping>() { },
        });
      };
      //return _db.Pizza.ToList(); //select * from pizza
      return domainPizzaList;
    }

    public void Update()
    {

    }

    public void Delete()
    {

    }

  }
}