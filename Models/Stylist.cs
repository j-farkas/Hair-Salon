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
      Stylist theStylist = db.stylist.Find(this.id);
      theClient.GrowHair();
      int damage = this.GetDamage();
      if(theClient.hair < damage)
      {
        //Client Dies
        theStylist.hair += theClient.hair;
        theClient.hair = 0;
      }else{
        //Client Lives
        theStylist.hair += damage;
        theClient.hair -= damage;
      }
      if(hair > this.GetNextLevel())
      {
        theStylist.hair = 0;
        theStylist.level++;
      }
      db.SaveChanges();
    }
    public int GetNextLevel()
    {
      return level*level*10;
    }


    public void GetDrop()
    {
      var db = new SalonContext();
      Random rnd = new Random();
      int rolls = this.GetLuck();
      Scissors scissors = new Scissors{prefix_1 = 0, prefix_2 = 0, suffix_1 = 0, suffix_2 = 0};
      for(int i = 0; i < rolls; i++)
      {
        int drop = (rnd.Next(0,10000)) % (30);
        if(scissors.prefix_1 == 0 && drop % 2 == 0)
        {
          var themod = db.prefix.Find(drop);
          if(themod != null)
          {
            scissors.prefix_1 = themod.id;
            scissors.prefix_1_value = rnd.Next(themod.min_value, themod.max_value);
          }
        }else if(scissors.prefix_2 == 0 && drop % 2 == 0)
        {
          var themod = db.prefix.Find(drop);
          if(themod != null && drop != scissors.prefix_1 )
          {
            scissors.prefix_2 = themod.id;
            scissors.prefix_2_value = rnd.Next(themod.min_value, themod.max_value);
          }
        }else if(scissors.suffix_1 == 0 && drop % 2 == 1)
        {
          var themod = db.suffix.Find(drop);
          if(themod != null)
          {
            scissors.suffix_1 = themod.id;
            scissors.suffix_1_value = rnd.Next(themod.min_value, themod.max_value);
          }
          }else if(scissors.prefix_2 == 0 && drop % 2 == 1)
          {
            var themod = db.suffix.Find(drop);
            if(themod != null && drop != scissors.suffix_1)
            {
              scissors.suffix_2 = themod.id;
              scissors.suffix_2_value = rnd.Next(themod.min_value, themod.max_value);
            }
          }
          scissors.name = scissors.GetScissorsName();
      }
      db.scissors.Add(scissors);
      db.SaveChanges();
      this.drop = scissors.id;
      db.SaveChanges();
    }

    public int GetLuck()
    {
      var db = new SalonContext();
      Random rnd = new Random();
      int luck = rnd.Next(2,6);
      Scissors scissors = db.scissors.Find(this.scissors);
      if(scissors.suffix_1 > 7 && scissors.suffix_1 < 11)
      {
          luck += scissors.suffix_1_value;
      }
      if(scissors.suffix_2 > 7 && scissors.suffix_2 < 11)
      {
          luck += scissors.suffix_1_value;
      }

      return luck;
    }
    public int GetDamage()
    {

      var db = new SalonContext();
      Scissors scissors = db.scissors.Find(this.scissors);
      float damage = level;
      if(scissors.suffix_1 > 0 && scissors.suffix_1 < 7)
      {
          if(scissors.suffix_1 % 2 == 1)
          {
            damage -= scissors.suffix_1_value;
          }else{
            damage += scissors.suffix_1_value;
          }
      }
      if(scissors.suffix_2 > 7 && scissors.suffix_2 < 11)
      {
        if(scissors.suffix_2 % 2 == 1)
        {
          damage -= scissors.suffix_1_value;
        }else{
          damage += scissors.suffix_1_value;
        }
      }
      if(scissors.prefix_1_value > 0)
      {
        damage += scissors.prefix_1_value;
      }

      if(scissors.prefix_2_value > 0)
      {
        damage += scissors.prefix_2_value;
      }
      if(damage < 1)
      {
        damage = 1;
      }
      return (int)damage;
    }
    public Scissors GetScissors()
    {
      return new SalonContext().scissors.Find(this.scissors);
    }

    public Scissors GetDropped()
    {
      return new SalonContext().scissors.Find(this.drop);
    }
  }
}
