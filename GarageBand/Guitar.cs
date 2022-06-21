using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{
    class Guitar : StringInstruments
    {
        public string Model { get; set; }

        public string Pickups { get; set; }


        public Guitar(string model, int strings, string pickups, string tuning, string TypeOfInstrument, string Name, int Octaves, bool Electric, bool frets, int nrfrets)
            : base(TypeOfInstrument, Name, Octaves, Electric)
        {
            Model = model;
            Strings = strings;
            Pickups = pickups;
            Tuning = tuning;


        }
        public Guitar() 
        {

        }


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Brand: "+ Name);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Strings: " + Strings);
            Console.WriteLine("Pickups: " + Pickups);
            Console.WriteLine("Tuning: " + Tuning);
            Console.WriteLine();
        }
        public override void Play()
        {
            Console.WriteLine("This Guitar plays like a motherf@£$ker");
        }
        public override void Player()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 2)
            {
                Play();
            }
        }
    }
}
