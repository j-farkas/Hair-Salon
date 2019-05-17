using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
    }

    public StylistTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=jared_farkas_test;";
    }

  [TestMethod]
   public void GetAll_CategoriesEmptyAtFirst_List()
   {
     //Arrange, Act

     //Assert
     Assert.AreEqual(0, new SalonContext().stylist.ToList().Count);
   }

   [TestMethod]
    public void GetAll_CategoriesNotEmpty_List()
    {
      //Arrange, Act
      Stylist addStylist = new Stylist{name = Name, description = Description, level = 1};
      db.stylist.Add(addStylist);
      db.SaveChanges();
      int result = new SalonContext().stylist.ToList().Count;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}
