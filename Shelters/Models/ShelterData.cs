using System.Collections.Generic;
using System;

namespace Shelters.Models
{
  public class ShelterData
  {
    // public ShelterData()
    // {
    //   this.Shelter = new HashSet<Shelter>();
    // }
    public int ShelterDataId { get; set; }
    public int CatsNumber { get; set; }
    public int DogsNumber { get; set; }
    public int ShelterId { get; set; }
  }
}