using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HairSalon.Models
{

  public class Join
  {
    public int id { get; set; }
    public int scissors_id { get; set; }
    public int client_id { get; set; }
    public int stylist_id { get; set; }
    public int prefix_id { get; set; }
    public int suffix_id { get; set; }

  }
}
