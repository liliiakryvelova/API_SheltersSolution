using System;
using System.Collections.Generic;

namespace Shelters.Models
{
  public class Shelter
  {
    // public Shelter()
    // {
    //   this.ShelterData = new HashSet<ShelterData>();
    // }
    public int ShelterId { get; set; }
    public string ShelterName { get; set ;}
    private DateTime _joined = DateTime.Now;

    public DateTime Date { get { return _joined;} set {_joined = value;}}
    // public virtual ICollection<ShelterData> ShelterData { get; set; }

  }
}