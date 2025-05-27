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

            //create a list of commando soldiers 
            Weapon MyWeapon = new Weapon("Tavor", "Israel", 13);

            List<Commando> Soldiers = new List<Commando> {
            new Commando("Elazar","TheShooter","Walk" ),
            new AirCommando("john", "TheEagle","Hidden" ),
            new SeaCommando("Bob","TheShark","Swim" )};


            //show the information of soldiers
            foreach( Commando o in Soldiers)
            {
                Console.WriteLine(o.SayName("General") );
                Console.WriteLine(o.CodeName);
                Console.WriteLine(o.Status);
                Console.WriteLine(string.Join(", ",o.Tools));
                Console.WriteLine();

            }

            //polymorphysm show tha attack function 
            foreach(Commando soldier in Soldiers)
            {
                soldier.Attack();
            }



        
        }
    }
}
