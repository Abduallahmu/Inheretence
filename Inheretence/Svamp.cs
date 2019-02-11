using System;
using System.Collections.Generic;
using System.Text;

namespace Inheretence
{
    class Svamp : IFarlig
    {
        public string Name { get; set; }

        public string Utsende { get; set; }
        private int nivå;
        public int Nivå { get { return nivå; } set { nivå = value; } }
        string beskrivning;

        public string Beskrivning { get { return beskrivning; } set { beskrivning = value; } }

        public void FarligInfo()
        {
            Console.WriteLine($"Farlig\n Nivå: {nivå}\nBeskrivning: {beskrivning}");
        }
    }
}
