using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Models
{

  public class Scissors
  {
    public string name { get; set; }
    public int prefix_1 { get; set; }
    public int prefix_1_value { get; set; }
    public int prefix_2 { get; set; }
    public int prefix_2_value { get; set; }
    public int suffix_1 { get; set; }
    public int suffix_1_value { get; set; }
    public int suffix_2 { get; set; }
    public int suffix_2_value { get; set; }
    public int quality {get; set;}
    public int id { get; set; }

    public string GetScissorsName()
    {
      string theScis = "";
      var db = new SalonContext();
      if(prefix_1 > 0)
      {
        theScis += db.prefix.Find(prefix_1).name;
      }
      if(prefix_2 > 0)
      {
        theScis += ", "+db.prefix.Find(prefix_2).name;
      }
      theScis += " Scissors";
      if(suffix_1 > 0)
      {
        theScis += " Of " + db.suffix.Find(suffix_1).name;
      }
      if(suffix_2 > 0)
      {
        theScis += " and "+db.suffix.Find(suffix_2).name;
      }
      return theScis;
    }


  }


}
