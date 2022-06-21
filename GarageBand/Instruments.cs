using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{
    public class Instruments
    {
        public string TypeOfInstrument { get; set; }
        public string Name { get; set; }
        public int Octaves { get; set; }
        public bool Electric { get; set; }

        public Instruments(string typeOfInstrument, string name, int octaves, bool electric)
        {
            TypeOfInstrument = typeOfInstrument;
            Name = name;
            Octaves = octaves;
            Electric = electric;

        }
        public Instruments()
        {

        }
        public virtual void Play()
        {

        }



        public virtual void Player()
        {
            int userInput = Int32.Parse(Console.ReadLine());
           


        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Type Of Instruments: " + TypeOfInstrument);
        }
    }   
}
