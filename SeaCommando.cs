using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string status) : 
            base(name, codeName,status)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"the sea commando {CodeName} attacks");
        }

        public void Swim()
        {
            Console.WriteLine("THe soldier swims");
            Status = "Swim";
        }
    }
}
