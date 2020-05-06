# Jurassic Park

A simple console application that help manages a zoo full of Dinosaurs.

# Includes

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
- [MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)

# Featured Code

```JSX
while (isRunning)
      {
        Console.WriteLine("Please select one of the options below:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("(VIEW) all dinosaurs, (ADD) a new dinosaur, (REMOVE) a dinosaur, (TRANSFER) a dinosaur to a new enclosure,");
        Console.WriteLine("(HEAVIEST) to view the top three heaviest dinosaurs, (DIET) to view dinosaur diets, or (QUIT) the program.");

        var input = Console.ReadLine().ToLower();
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
```
