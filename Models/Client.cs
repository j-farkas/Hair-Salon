using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HairSalon.Models
{
  public class Client
  {
    public int id { get; set; }
    public string name { get; set; }
    public int stylist { get; set; }
    public int hair { get; set; }
    public string haircut { get; set; }


    public List<Stylist> GetStylists()
    {
      var db = new SalonContext();
      List<Stylist> allItems = new List<Stylist> {};
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.client_id == id && item.stylist_id > 0 )
        {
          allItems.Add(db.stylist.Find(item.stylist_id));
        }
      }
      return allItems;
    }
  }
}
