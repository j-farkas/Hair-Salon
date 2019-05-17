using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HairSalon.Models
{
  public class Client
  {
    private string name { get; set; }
    private int id { get; set; }
    private int stylist { get; set; }
    private int hair { get; set; }
    private string haircut { get; set; }

    public static List<Client> GetClients(int num)
    {
      var db = new SalonContext();
      List<Client> allItems = new List<Client> {};
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.stylist_id == num && item.client_id > 0 )
        {
          allItems.Add(db.client.Find(item.client_id));
        }
      }
      return allItems;
    }
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
