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

    public int GetDamage()
    {
      return id;
    }
  }


}
