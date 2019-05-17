using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HairSalon.Models
{
  public class Stylist
  {
    private string name {get; set; }
    private int id {get; set; }
    private string description {get; set; }
    private int level {get; set; }
    private int hair {get; set; }
    private int scissors {get; set; }
    private int drop {get; set; }


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
