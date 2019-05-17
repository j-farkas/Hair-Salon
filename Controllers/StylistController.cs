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
        Stylist addStylist = new Stylist{name = Name, description = Description};
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
  }
}
