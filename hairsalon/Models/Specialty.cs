using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Models
{

  public class Specialty
  {
    public string name { get; set; }
    public int id { get; set; }

    public List<Stylist> GetStylists()
    {
      var db = new SalonContext();
      List<Stylist> allItems = new List<Stylist> {};
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.specialty_id == id && item.stylist_id > 0 )
        {
          allItems.Add(db.stylist.Find(item.stylist_id));
        }
      }
      return allItems;
    }

    public List<Stylist> GetRemainingStylists()
    {

      List<int> found = new List<int>{};
      var db = new SalonContext();
      List<Stylist> allItems = new List<Stylist>();
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.specialty_id == id && item.stylist_id > 0 )
        {
          found.Add(item.stylist_id);
        }
      }

      foreach(Stylist spec in Stylist.GetAll())
      {
        if(found.Contains(spec.id) == false)
        {
          allItems.Add(spec);
        }
      }
      return allItems;
    }

    public static List<Specialty> GetAll()
    {
      return new SalonContext().specialty.ToList();
    }

    public static void ClearAll()
    {
      var db = new SalonContext();
      db.specialty.RemoveRange(db.specialty);
      db.SaveChanges();
    }
  }
}
