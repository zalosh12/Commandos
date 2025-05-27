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

            AirCommando second = new AirCommando(
                "john",
                "TheEagle",
                new string[] { "Hammer", "chisel", "rope", "bag", "water bottle" },
                "Hidden"
                );

            SeaCommando thirt = new SeaCommando(
                "Bob",
                "TheShark",
                new string[] { "Hammer", "chisel", "rope", "bag", "water bottle" },
                "Swim"
                );

            //Console.WriteLine(first.SayName("Colonel"));  
            //Console.WriteLine(first.SayName("General"));
            //Console.WriteLine(first.SayName("Lutennet"));

            //first.Walk();
            //first.Attack();

            //MyWeapon.Shoot();

            //Console.WriteLine(first.CodeName);

            //first.CodeName = "TheTitan";

            //Console.WriteLine(first.CodeName);
        }
    }
}
