using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando first = new Commando(
                "Elazar",
                "TheShooter",
                new string[] { "Hammer", "chisel", "rope", "bag", "water bottle"},
                "Walk" );

            Weapon MyWeapon = new Weapon("Tavor", "Israel", 13);

            first.Walk();
            first.Attack();

            MyWeapon.Shoot();
        }
    }
}
