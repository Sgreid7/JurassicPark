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
      if (Dinosaurs.Count <= 0)
      {
        Console.WriteLine("I'm sorry, there are currently 0 dinosaurs in Jurassic Park.");
      }
      else
      {
        Console.WriteLine("Here are the current dinosaurs in Jurassic Park:");
        foreach (Dinosaur d in list)
        {
          Console.WriteLine("------------------------------------------------");
          Console.WriteLine($"Name: {d.Name}");
          Console.WriteLine($"Diet Type: {d.Diet}");
          Console.WriteLine($"Date Acquired: {d.DateAcquired}");
          Console.WriteLine($"Weight: {d.Weight}lbs");
          Console.WriteLine($"Enclosure Number: {d.EnclosureNumber}");
          Console.WriteLine($"Unique ID: {d.ID}");
          Console.WriteLine("------------------------------------------------");
        }
      }
    }

    // Add dinosaurs
    public void Add()
    {
      Console.WriteLine("You have chosen to add a dinosaur.");
      // Prompt user to enter dinosaur attributes
      Console.WriteLine("Please enter a name:");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
      var name = Console.ReadLine();
      // Add space for readability
      Console.WriteLine();
      Console.WriteLine("Please enter a type of diet (herbivore) or (carnivore)");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      var diet = Console.ReadLine().ToLower();
      // Add space for readability
      Console.WriteLine();

      // Validate diet
      while (diet != "herbivore" && diet != "carnivore")
      {
        Console.WriteLine("I'm sorry, that is not a valid diet type.");
        Console.WriteLine("Please enter a type of diet (herbivore or carnivore):");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        diet = Console.ReadLine().ToLower();
      }
      // Add space for readability
      Console.WriteLine();
      var date = DateTime.Now;
      Console.WriteLine("Please enter the dinosaur's weight:");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      var weight = int.Parse(Console.ReadLine());
      // Add space for readability
      Console.WriteLine();
      Console.WriteLine("Please enter a number to choose a pen that will store the dinosaur.");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      var enclosure = int.Parse(Console.ReadLine());
      // Add space for readability
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
      Console.WriteLine("You have chosen to remove a dinosaur. Please select the unique ID for the dinosaur you wish to remove.");
      View(Dinosaurs);
      var input = int.Parse(Console.ReadLine());
      var removeDino = Dinosaurs.First(dino => dino.ID == input);
      Dinosaurs.Remove(removeDino);
    }

    public void Transfer()
    {
      Console.WriteLine("Which dinosaur would you like to transfer? Please select the unique ID.");
      View(Dinosaurs);
      // Add space for readability
      Console.WriteLine();
      var input = Console.ReadLine();
      int dinoID;
      var isNum = int.TryParse(input, out dinoID);

      // Validate that the unique ID entered exists
      while (!Dinosaurs.Any(dino => dino.ID == dinoID))
      {
        Console.WriteLine("I'm sorry, that is not a valid dinosaur ID.");
        Console.WriteLine("Please select a dinosaur ID.");
        dinoID = int.Parse(Console.ReadLine());
      }
      // Add space for readability
      Console.WriteLine();
      Console.WriteLine("Please choose a new enclosure to put the dinosaur in. Please enter a number.");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      var newEnclosure = int.Parse(Console.ReadLine());
      Dinosaurs.First(d => d.ID == dinoID).EnclosureNumber = newEnclosure;
    }

    public void Heaviest()
    {
      Console.WriteLine("You have chosen to view the three heaviest dinosaurs.");
      var topThree = Dinosaurs.OrderByDescending(d => d.Weight).Take(3).ToList();
      View(topThree);
    }

    public void DietSummary()
    {
      Console.WriteLine("You want to view the total number of herbivores and carnivores.");
      var totalCarnivores = Dinosaurs.Where(dino => dino.Diet == "carnivore").Count();
      var totalHerbivores = Dinosaurs.Where(dino => dino.Diet == "herbivore").Count();
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine($"Total number of carnivores: {totalCarnivores}");
      Console.WriteLine($"Total number of herbivores: {totalHerbivores}");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
  }
}