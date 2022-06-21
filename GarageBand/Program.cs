using System;

namespace GarageBand
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            inventory.PrintAllInfo();
            Guitar guitar = (new Guitar("Telecaster", 6, "Single-Coil(bridge and neck)", "Standard", "String Instrument", "Fender", 4, true, true, 22));
            Bass bass = (new Bass("Ltd", 4, "Esp", "Standard", "String Instrument", "Esp ltd 204", 4, true, 22));
            Keys keys = (new Keys("Piano", 88, "Digital Piano", "Yamaha", 7, true));
            Console.WriteLine("Press to Play");
            
            while (true)
            {
                
                int userInput = Int32.Parse(Console.ReadLine());


                if (userInput == 1)
                {
                    bass.Play();
                }
                if (userInput == 2)
                {
                    guitar.Play();
                }
                if(userInput == 3)
                {
                    keys.Play();
                }
                if(userInput == 4)
                {
                    inventory.NewEntry();
                    inventory.PrintAllInfo();
                }
                if(userInput == 0)
                {
                    break;
                }
            }
            
            
        }
    }
}
