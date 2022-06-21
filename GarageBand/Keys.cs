using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{
    class Keys : Instruments
    {
        public string TypeOfKeys { get; set; }
        public int NrOfKeys { get; set; }

       

        public Keys(string typeOfKeys, int nrOfKeys, string TypeOfInstrument, string Name, int Octaves, bool Electric) : base(TypeOfInstrument, Name, Octaves, true)
        {
            NrOfKeys = nrOfKeys;
            TypeOfKeys = typeOfKeys;
        }

        public Keys()
        {
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Model: " + Name);
            Console.WriteLine("Type of Piano: " + TypeOfKeys);
            Console.WriteLine("Nr of Keys: " + NrOfKeys);
            Console.WriteLine("Electric: " + Electric);
            Console.WriteLine();
        }
        public override void Play()
        {
            Console.WriteLine("The Piano has been drinking.");
        }
        public override void Player()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 3)
            {
                Play();
            }

        }
        


    }
}
