using System;
using System.Linq;

namespace SafariVacation
{
  class Program
  {
    public static void ReadData()
    {
      var db = new SafariContext();
      var allAnimalsSeen = db.Safaris.Where(s => s.CountOfTimesSeen <= 5);
    }
    static void Main(string[] args)
    {

    }
  }
}
