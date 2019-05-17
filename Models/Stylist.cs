

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
      List<Client> allItems = db.client.Where(c => c.stylist == id).ToList();
      return allItems;
    }

    public List<Specialty> GetSpecialties()
    {
      var db = new SalonContext();
      List<Specialty> allItems = new List<Specialty> {};
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.stylist_id == id && item.specialty_id > 0 )
        {
          allItems.Add(db.specialty.Find(item.specialty_id));
        }
      }
      return allItems;
    }

    public List<Specialty> GetRemainingSpecialties()
    {

      List<int> found = new List<int>{};
      var db = new SalonContext();
      List<Specialty> allItems = new List<Specialty>();
      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.stylist_id == id && item.specialty_id > 0 )
        {
          found.Add(item.specialty_id);
        }
      }

      foreach(Specialty spec in Specialty.GetAll())
      {
        if(found.Contains(spec.id) == false)
        {
          allItems.Add(spec);
        }
      }
      return allItems;
    }

    public static List<Stylist> GetAll()
    {
      return new SalonContext().stylist.ToList();
    }

    public void CutHair(int id)
    {
      var db = new SalonContext();
      Client theClient = db.client.Find(id);
      theClient.GrowHair();
      int damage = level;
      Scissors theScissors = db.scissors.Find(scissors);
      if(theScissors != null)
      {
        damage += theScissors.GetDamage();
      }
      if(theClient.hair < damage)
      {
        //Client Dies
        this.hair += theClient.hair;
        theClient.hair = -1;
      }else{
        //Client Lives
        this.hair += damage;
        theClient.hair -= damage;
      }
      if(hair > this.GetNextLevel())
      {
        hair = 0;
        level++;
      }
      db.SaveChanges();
    }
    public int GetNextLevel()
    {
      return level*level*10;
    }

  }
}
