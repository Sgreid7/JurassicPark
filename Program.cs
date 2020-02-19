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
        Console.WriteLine("------------------------------------------");
        // Present the user with different options to choose from
        Console.WriteLine("(VIEW) all dinosaurs, (ADD) a new dinosaur, (REMOVE) a dinosaur, (TRANSFER) a dinosaur to a new enclosure, (HEAVIEST) to view 3 heaviest dinosaurs, (DIET) to view dinosaur diets, or (QUIT) the program.");
        // Receive user input
        var input = Console.ReadLine().ToLower();
        // Add a space for readability
        Console.WriteLine();
        // Create a switch statement 
        switch (input)
        {
          case "view":
            Console.WriteLine("You have chosen to view the dinosaurs.");
            // Create a method to view dinosaurs
            dinoTracker.View();
            break;

          case "add":
            // Create a method to add a dinosaur
            dinoTracker.Add();
            break;

          case "remove":
            dinoTracker.Remove();
            // Create a method to remove a dinosaur
            break;

          case "transfer":
            Console.WriteLine("You have chosen to transfer a dinosaur. Please choose a new enclosure to put the dinosaur in.");
            // Create a method to transfer dinosaurs
            break;

          case "heaviest":
            Console.WriteLine("You have chosen to view the three heaviest dinosaurs.");
            // Create a method to display the top 3 heaviest dinosaurs
            break;

          case "diet":
            Console.WriteLine("You want to view the total number of herbivores and carnivores.");
            // Create a method to list the total number of herbivores and carnivores
            break;

          case "quit":
            Console.WriteLine("You have chosen to quit the program. Thanks for coming to Jurassic Park, we hope to see you again. Safe travels!");
            // Switch the isRunning variable to false
            isRunning = false;
            break;
        }


      }
    }
  }
}
