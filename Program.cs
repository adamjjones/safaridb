using System;
using System.Linq;

namespace SafariVacation
{
  class Program
  {
    public static void ReadData()
    {
      var db = new SafariContext();
      var animals = db.Animals.Select(s => s);
      // var animals = db.Animals;
      foreach (var row in animals)
        Console.WriteLine(String.Format("We saw {0} {1} in {2}",
            row.CountOfTimesSeen,
            row.Species,
            row.LocationOfLastSeen));
    }

    public static void UpdateData()
    {
      var db = new SafariContext();
      //   var bestMovie = db.Safaris.FirstOrDefault(count => count.CountOfTimesSeen) && (count.LocationOfLastSeen)
      db.SaveChanges();
    }

    public static void ReadJungle()
    {
      var db = new SafariContext();
      var allAnimalsSeen = db.Animals.Select(location => location.LocationOfLastSeen);
    }

    public static void DeleteData()
    {
      var db = new SafariContext();
      var deleteRecord = db.Animals.FirstOrDefault(s => s.LocationOfLastSeen == "Desert");
      db.SaveChanges();
    }

    public static void SumData()
    {
      var db = new SafariContext();
      //   var sum = db.Safaris.Aggregate(sum, s) => s.CountOfTimesSeen + sum);
    }

    static void Main(string[] args)
    {

    }
  }
}
