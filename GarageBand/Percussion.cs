using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{ 
    class Percussion : Instruments
    {
        public string TypeOfPerc { get; set; }

        public bool Pitched { get; set; }
        public Percussion(string typeOfPerc, bool pitched, string typeOfInstrument, string name, int octaves, bool electric)
        : base(typeOfInstrument,name,octaves,electric)
        {
            TypeOfPerc = typeOfPerc;
            Pitched = pitched;
        }

        public Percussion()
        {
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type of Perc: " + TypeOfPerc);
            Console.WriteLine("Picthed: " +Pitched);
            Console.WriteLine();
        }
    }
}
