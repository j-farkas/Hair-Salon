using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    [HttpGet("/Stylist")]
    public ActionResult Index()
    {
      return View(new SalonContext().stylist.ToList());
    }

    [HttpGet("/Stylist/New")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/Stylist")]
    public ActionResult New(string Name, string Description)
    {
        var db = new SalonContext();
        Stylist addStylist = new Stylist{name = Name, description = Description, level = 1};
        db.stylist.Add(addStylist);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet("/Stylist/{id}")]
    public ActionResult Show(int id)
    {
      Stylist theStylist = new SalonContext().stylist.Find(id);
      return View(theStylist);
    }

    [HttpPost("/Stylist/{id}/Edit")]
    public ActionResult EditName(int id, string Name)
    {
      var db = new SalonContext();
      var stylist = db.stylist.Find(id);
      if (Name != null)
      {
        stylist.name = Name;
      }
      db.SaveChanges();
      return RedirectToAction("Show", new {id = id});
    }

    [HttpPost("/Stylist/{id}/Delete")]
    public ActionResult Delete(int id)
    {
      var db = new SalonContext();
      var stylist = db.stylist.Find(id);
      db.stylist.Remove(stylist);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost("/Client/{id}/Delete")]
    public ActionResult DeleteClient(int id)
    {
      var db = new SalonContext();
      var client = db.client.Find(id);
      int stylist = db.stylist.Find(client.stylist).id;
      db.client.Remove(client);
      db.SaveChanges();
      return RedirectToAction("Show", new {id = stylist});
    }

    [HttpPost("/Stylist/Delete")]
    public ActionResult DeleteAllStylists()
    {
      var db = new SalonContext();
      db.stylist.RemoveRange(db.stylist);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost("/Client/Delete")]
    public ActionResult DeleteAllClients()
    {
      var db = new SalonContext();
      db.client.RemoveRange(db.client);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("/Stylist/{id}/Replace")]
    public ActionResult Replace(int id)
    {
      return View(new SalonContext().stylist.Find(id));
    }

    [HttpPost("/Client")]
    public ActionResult Add(string Name, int Stylist)
    {
        var db = new SalonContext();
        Random rnd = new Random();
        Client addClient = new Client{name = Name, stylist = Stylist, hair = rnd.Next(10,50)};
        db.client.Add(addClient);
        db.SaveChanges();
        return RedirectToAction("Show", new {id = Stylist});
    }

    [HttpPost("/Stylist/{id}/Specialty")]
    public ActionResult AddStylistToSpecialty(int id, int specialtyId)
    {
        var db = new SalonContext();
        Join addSpecialty = new Join{specialty_id = specialtyId, stylist_id = id};
        db.join.Add(addSpecialty);
        db.SaveChanges();
        return RedirectToAction("Show", new {id = id});
    }

    [HttpPost("/Stylist/{id}/Replace")]
    public ActionResult ReplaceScissors(int id, bool change)
    {
        var db = new SalonContext();
        Stylist theStylist = db.stylist.Find(id);
        if(change == true)
        {
          theStylist.scissors = theStylist.drop;
        }
        theStylist.drop = 0;
        db.SaveChanges();
        return RedirectToAction("Show", new {id = id});
    }
  }
}
