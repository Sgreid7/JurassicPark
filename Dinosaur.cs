using System;
namespace JurassicPark
{
  public class Dinosaur
  {
    // ***** CREATE PROPERTIES FOR EACH DINOSAUR
    // Name
    public string Name { get; set; }

    // Diet Type
    public string Diet { get; set; }

    // Date dinosaur was entered in Jurassic Park
    public DateTime DateAcquired { get; set; } = DateTime.Now;

    // Dinosaur weight
    public int Weight { get; set; }

    // Enclosure Pen number (holding place for dinosaurs)
    public int EnclosureNumber { get; set; }

    // Unique ID for dinosaur
    public int ID { get; set; }
  }
}