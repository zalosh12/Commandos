using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class AirCommando: Commando
    {
        public AirCommando(string name, string codeName, string[] tools, string status) 
            : base(name, codeName, tools, status)
        {
        }

        public void Parachute()
        {
            Console.WriteLine("The soldier parachute");
            Status = "Parachute";
        }
    }
}
