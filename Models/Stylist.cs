using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int id {get; set; }
    public string name {get; set; }
    public string description {get; set; }
    public int level {get; set; }
    public int hair {get; set; }
    public int scissors {get; set; }
    public int drop {get; set; }


    public List<Client> GetClients()
    {
      var db = new SalonContext();
      List<Client> allItems = new List<Client> {};
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.stylist_id == id && item.client_id > 0 )
        {
          allItems.Add(db.client.Find(item.client_id));
        }
      }
      return allItems;
    }
  }
}
