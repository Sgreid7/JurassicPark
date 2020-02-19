using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinosaurTracker
  {
    public List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();

    // View dinosaurs
    public void View()
    {
      foreach (Dinosaur d in Dinosaurs)
      {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Name: {d.Name}");
        Console.WriteLine($"Diet Type: {d.Diet}");
        Console.WriteLine($"Date Acquired: {d.DateAcquired}");
        Console.WriteLine($"Weight: {d.Weight}");
        Console.WriteLine($"Enclosure Number: {d.EnclosureNumber}");
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
        EnclosureNumber = enclosure
      };
      Dinosaurs.Add(dinosaur);
    }

    public void Remove()
    {
      Console.WriteLine("You have chosen to remove a dinosaur. Please select which dinosaur to remove.");
      Console.WriteLine("Which dinosaur would you like to remove?");
      View();
      var input = Console.ReadLine().ToLower();
      var removeDino = Dinosaurs.First(dino => dino.Name == input);
      Dinosaurs.Remove(removeDino);
    }
  }
}