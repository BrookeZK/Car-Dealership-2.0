using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car paseo = new Car("1992 Toyota Paseo", 2000, 150000, "Sportier version of the Yote Tercel. Wow - mow down those corn fields! Whip them corners. Ride in Style");
      Car emonda = new Car("2019 Emonda Trek", 14000, 3500, "14 grand? 14 grand?! Is wortthhh ittttttt. Lightest bike on the market. Can / MAKE you win Tour de France. It's deffo special");
      Car crx = new Car("1990 Super Fly Hondi CRX", 3500, 94000, "Best. CCar. If. You. Can. Even. Find. One. Never Sells this babe, once you get it. Hot dates only");
      Car nissan = new Car("1985 Nissan 720 - 4x4, lift kit", 5600, 75000, "X-TREME MUDDER. Come pick me up from the swamp");

      List<Car> Cars = new List<Car>() { paseo, emonda, crx, nissan };

      Console.WriteLine("Enter Max Price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter Max Mileage: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);


      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if (CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("No current options that match");
        Main();
      }
    
      foreach(Car automobile in CarsMatchingSearch)
      {
        automobile.SetExclamation("!!!!!!!");
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine("Things to Know: " + automobile.GetMessage());

      }
    }
  }

}
