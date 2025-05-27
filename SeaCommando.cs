using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string[] tools, string status) : 
            base(name, codeName, tools, status)
        {
        }

        public void Swim()
        {
            Console.WriteLine("THe soldier swims");
            Status = "Swim";
        }
    }
}
