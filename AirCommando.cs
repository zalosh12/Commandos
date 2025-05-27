using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando: Commando
    {
        public AirCommando(string name, string codeName,string status) 
            : base(name, codeName,status)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"The air commando {CodeName} attacks");
        }

        public void Parachute()
        {
            Console.WriteLine($"The soldier {CodeName} parachute");
            Status = "Parachute";
        }
    }
}
