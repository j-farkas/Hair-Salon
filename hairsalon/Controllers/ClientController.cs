using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("/Client/New")]
    public ActionResult New()
    {
      return View(new SalonContext().stylist.ToList());
    }

    [HttpGet("/Client/{id}")]
    public ActionResult Show(int id)
    {
      Client theClient = new SalonContext().client.Find(id);
      return View(theClient);
    }

    [HttpPost("/Client/{id}")]
    public ActionResult EditStylist(int id, int stylist)
    {
      var db = new SalonContext();
      Client theClient = db.client.Find(id);
      theClient.stylist = stylist;
      db.SaveChanges();
      return RedirectToAction("Show", new {id = id});
    }

    [HttpGet("/Client/{id}/Edit")]
    public ActionResult Edit(int id)
    {
      Client theClient = new SalonContext().client.Find(id);
      return View(theClient);
    }

    [HttpPost("/Client/{id}/Edit")]
    public ActionResult EditClient(int id, string Name)
    {
      var db = new SalonContext();
      var client = db.client.Find(id);
      if (Name != null)
      {
        client.name = Name;
      }
      db.SaveChanges();

      return RedirectToAction("Show", new {id = id});
    }

    [HttpPost("/Client/{id}/Cut")]
    public ActionResult CutHair(int id)
    {
      var db = new SalonContext();
      Client client = db.client.Find(id);
      Stylist stylist = db.stylist.Find(client.stylist);
      stylist.CutHair(client.id);
      client = db.client.Find(id);
      if(client.hair <= 0)
      {
        //Client died
        db.client.Remove(client);
        stylist.GetDrop();
        db.SaveChanges();
        return RedirectToAction("Replace", "Stylist", new {id = stylist.id});
      }
      return RedirectToAction("Show", new {id = id});
    }
  }
}
