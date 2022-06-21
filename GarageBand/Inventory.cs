using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{
    internal class Inventory
    {
        public List<Instruments> Instruments { get; set; }
        public Inventory()
        {
            Instruments = new List<Instruments>();
            Instruments.Add(new Bass("Ltd", 4, "Esp", "Standard", "String Instrument", "Esp ltd 204", 4, true,22));
            Instruments.Add(new Bass("Precision", 4, "Single-Coil", "Standard", "String Instrument", "Squire", 4, true,22));
            Instruments.Add(new Guitar("Telecaster", 6, "Single-Coil(bridge and neck)", "Standard", "String Instrument", "Fender", 4,true, true,22));
            Instruments.Add(new Guitar("T-300",6,"Humbuckers(bridge and neck)","Open-G","String Instrument","Gretsch",4,true, true,22));
            Instruments.Add(new Guitar("Dreadnought", 6, "none", " One Step down Strandard", "String Instrument", "Guild", 4, false,true,22));
            Instruments.Add(new Keys("Upright", 88, "Piano", "Weissbrod Einesberg", 7, false));
            Instruments.Add(new Keys("Digital", 72, "Keyboard", "Nord Electro", 6, true));
            Instruments.Add(new Percussion("DrumKit", false, "Percussion", "Pearl", 1, false));
            Instruments.Add(new Percussion("Maracas",false,"Percussion","Gecko",0, false));

        }
        public void PrintAllInfo()
        {
            foreach( var instrument in Instruments)
            {
                instrument.PrintInfo();
            }
        }
        public void NewEntry()
        {
            
            Console.WriteLine("Write in Type of instrument");
            var userInput = Console.ReadLine();
            if(userInput == "Guitar") 
            {
                var newinstrument = new Guitar();
                newinstrument.TypeOfInstrument = Console.ReadLine();
                Console.WriteLine("Write in Name of Brand: ");
                newinstrument.Name = Console.ReadLine();
                Console.WriteLine("Write in Name of Model");
                newinstrument.Model = Console.ReadLine();
                Console.WriteLine("PickUps?");
                newinstrument.Pickups = Console.ReadLine();
                Console.WriteLine("Nr of Strings");
                newinstrument.Strings =  Int32.Parse(Console.ReadLine());
                Console.WriteLine(" and tuning?");
                newinstrument.Tuning = Console.ReadLine();
                Console.WriteLine("Write in Electric or not");
                var isElectric = "true";
                newinstrument.Electric = isElectric == Console.ReadLine() ? true : false;
                Instruments.Add(newinstrument);
            }
            if(userInput== "Bass")
            {
                var newinstrument = new Bass();
                newinstrument.TypeOfInstrument = Console.ReadLine();
                Console.WriteLine("Write in Name of Brand: ");
                newinstrument.Name = Console.ReadLine();
                Console.WriteLine("Write in Name of Model");
                newinstrument.Model = Console.ReadLine();
                Console.WriteLine("PickUps?");
                newinstrument.Pickups = Console.ReadLine();
                Console.WriteLine("Nr of Strings");
                newinstrument.Strings = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" and tuning?");
                newinstrument.Tuning = Console.ReadLine();
                Console.WriteLine("Write in Electric or not");
                var isElectric = "true";
                newinstrument.Electric = isElectric == Console.ReadLine() ? true : false;
                Instruments.Add(newinstrument);
            }
            if (userInput == "Keys")
            {
                var newinstrument = new Keys();
                newinstrument.TypeOfInstrument = Console.ReadLine();
                Console.WriteLine("Write in Name of Brand: ");
                newinstrument.Name = Console.ReadLine();
                Console.WriteLine("Write in Type of Keyboard");
                newinstrument.TypeOfKeys = Console.ReadLine();
                Console.WriteLine("Nr of Keys");
                newinstrument.NrOfKeys = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Write in Electric or not");
                var isElectric = "true";
                newinstrument.Electric = isElectric == Console.ReadLine() ? true : false;
                Instruments.Add(newinstrument);
            }
            if(userInput == "Perc")
            {
                var newinstrument = new Percussion();
                newinstrument.TypeOfInstrument = Console.ReadLine();
                Console.WriteLine("Write in Name of Perc: ");
                newinstrument.Name = Console.ReadLine();
                Console.WriteLine("Type Of Percussion: ");
                newinstrument.TypeOfPerc = Console.ReadLine();
                Console.WriteLine("Is Pitched?  ");
                var isPitched = "true";
                newinstrument.Pitched = isPitched == Console.ReadLine() ? true : false;
                Instruments.Add(newinstrument);

            }
            else
            {
                var newinstrument = new Instruments();
            }




        }
    }
}
