using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HairSalon.Controllers
{
  public class SpecialtyController : Controller
  {

    [HttpGet("/Specialty/New")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/Specialty")]
    public ActionResult Index()
    {
      return View(new SalonContext().specialty.ToList());
    }

    [HttpGet("/Specialty/{id}")]
    public ActionResult Show(int id)
    {
      Specialty theSpecialty = new SalonContext().specialty.Find(id);
      return View(theSpecialty);
    }

    [HttpPost("/Specialty")]
    public ActionResult AddSpecialty(string Name)
    {
        var db = new SalonContext();
        Specialty addSpecialty = new Specialty{name = Name};
        db.specialty.Add(addSpecialty);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

  }
}
