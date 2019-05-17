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
  }
}
