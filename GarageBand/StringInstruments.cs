using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{
     public class StringInstruments : Instruments
    {
        public int Strings { get; set; }
        public string Tuning { get; set; }

        public bool Frets { get; set; }
        public int NrFrets { get; set; }
        public StringInstruments(int strings,string tuning, bool frets, int nrfrets, string typeOfInstrument,string name,int octaves, bool electric ): base( typeOfInstrument,name,octaves,true)
        {
            Strings = strings;
            Tuning = tuning;
            Frets = frets;
            NrFrets = nrfrets;

        }
        public StringInstruments()
        {

        }
      

        
        public StringInstruments(string typeOfInstrument, string name, int octaves, bool electric) : base(typeOfInstrument, name, octaves, electric)
        {
        }
    }
}
