using System;
using System.Collections.Generic;
using System.Text;

namespace Inheretence
{
    class Djur
    {
        public string Name { get; set; }


        public virtual void Info()
        {
            Console.WriteLine("Djur: " + Name);
        }

        public override string ToString()
        {
            return base.ToString() + " Override ";
        }
    }
}
