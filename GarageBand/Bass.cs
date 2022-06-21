using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageBand
{
    public class Bass : StringInstruments
    {
        public string Model { get; set; }
        
        public string Pickups { get; set; }
       

        public Bass(string model, int strings, string pickups, string tuning, string TypeOfInstrument, string Name, int Octaves, bool Electric,int nrfrets) 
            :base(strings,tuning,true,nrfrets,TypeOfInstrument,Name, Octaves,true)
        {
            Model = model;
            Strings = strings;
            Pickups = pickups;
            Tuning = tuning;
            

        }

        public Bass()
        {
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Brand: "+ Name);
            Console.WriteLine("Model: "+ Model); 
            Console.WriteLine("Strings: "+ Strings); 
            Console.WriteLine("Pickups: "+ Pickups); 
            Console.WriteLine("Tuning: "+ Tuning);
            Console.WriteLine();
            
           
        }

        public override void Play()
        {
            Console.WriteLine("The bass plays a lower octave.");
        }
        public override void Player()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Play();
            }

        }
    }


}
