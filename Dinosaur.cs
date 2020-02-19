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

    // Date dinosaur was acquired
    public DateTime DateAcquired { get; set; }

    // Weight
    public int Weight { get; set; }

    // Enclosure Pen number
    public int EnclosureNumber { get; set; }
  }
}