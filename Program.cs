using System;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      var dinoTracker = new DinosaurTracker();
      var isRunning = true;
      // Greet the user
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Greetings, traveler, welcome to the notorious Jurassic Park!");
      Console.WriteLine("What would you like to do today?");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      while (isRunning)
      {
        // Add space for readability
        Console.WriteLine();
        Console.WriteLine("Please select one of the options below:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        // Present the user with different options to choose from
        Console.WriteLine("(VIEW) all dinosaurs, (ADD) a new dinosaur, (REMOVE) a dinosaur, (TRANSFER) a dinosaur to a new enclosure,");
        Console.WriteLine("(HEAVIEST) to view the top three heaviest dinosaurs, (DIET) to view dinosaur diets, or (QUIT) the program.");
        // Receive user input
        var input = Console.ReadLine().ToLower();
        // Add a space for readability
        Console.WriteLine();
        // Create a switch statement 
        switch (input)
        {
          case "view":
            dinoTracker.View(dinoTracker.Dinosaurs);
            break;

          case "add":
            dinoTracker.Add();
            break;

          case "remove":
            dinoTracker.Remove();
            break;

          case "transfer":
            dinoTracker.Transfer();
            break;

          case "heaviest":
            dinoTracker.Heaviest();
            break;

          case "diet":
            dinoTracker.DietSummary();
            break;

          case "quit":
            Console.WriteLine("You have chosen to quit the program. Thanks for coming to Jurassic Park, we hope to see you again. Safe travels!");
            isRunning = false;
            break;
        }
      }
    }
  }
}
