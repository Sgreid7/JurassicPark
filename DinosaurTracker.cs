using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinosaurTracker
  {
    public List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();

    public int UniqueID { get; set; } = 1;

    // View dinosaurs
    public void View(List<Dinosaur> list)
    {
      foreach (Dinosaur d in list)
      {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Name: {d.Name}");
        Console.WriteLine($"Diet Type: {d.Diet}");
        Console.WriteLine($"Date Acquired: {d.DateAcquired}");
        Console.WriteLine($"Weight: {d.Weight}");
        Console.WriteLine($"Enclosure Number: {d.EnclosureNumber}");
        Console.WriteLine($"Unique ID: {d.ID}");
        Console.WriteLine("--------------------------------------");
      }
    }

    // Add dinosaurs
    public void Add()
    {
      Console.WriteLine("You have chosen to add a dinosaur.");
      // Prompt user to enter dinosaur attributes
      Console.WriteLine("Please enter a name:");
      var name = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("Please enter a type of diet (herbivore or carnivore)");
      var diet = Console.ReadLine();
      Console.WriteLine();
      var date = DateTime.Now;
      Console.WriteLine("Please enter the dinosaur's weight:");
      var weight = int.Parse(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Please enter a number to choose a pen that will store the dinosaur.");
      var enclosure = int.Parse(Console.ReadLine());
      Console.WriteLine();

      // Create an instance of dinosaur
      var dinosaur = new Dinosaur
      {
        Name = name,
        Diet = diet,
        DateAcquired = date,
        Weight = weight,
        EnclosureNumber = enclosure,
        ID = UniqueID
      };
      Dinosaurs.Add(dinosaur);
      UniqueID++;
    }

    public void Remove()
    {
      Console.WriteLine("You have chosen to remove a dinosaur. Please select which dinosaur to remove.");
      Console.WriteLine("Which dinosaur would you like to remove?");
      View(Dinosaurs);
      var input = int.Parse(Console.ReadLine());
      var removeDino = Dinosaurs.First(dino => dino.ID == input);
      Dinosaurs.Remove(removeDino);
    }

    public void Transfer()
    {
      Console.WriteLine("You have chosen to transfer. Which dinosaur would you like to transfer? Please select the unique ID.");
      View(Dinosaurs);
      Console.WriteLine("---------------------------------------------------------");
      Console.WriteLine("Please choose a new enclosure to put the dinosaur in. Please select a number.");
      var dinoID = int.Parse(Console.ReadLine());
      var input = int.Parse(Console.ReadLine());
      Dinosaurs.First(d => d.ID == dinoID).EnclosureNumber = input;
    }

    public void Heaviest()
    {
      Console.WriteLine("You have chosen to view the three heaviest dinosaurs.");
      var topThree = Dinosaurs.OrderByDescending(d => d.Weight).Take(3).ToList();
      View(topThree);
    }
  }
}