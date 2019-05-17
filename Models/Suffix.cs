using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Models
{

  public class Suffix
  {
    public string name { get; set; }
    public int max_value { get; set; }
    public int min_value { get; set; }
    public int id { get; set; }
  }
}
