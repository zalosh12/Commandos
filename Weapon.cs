using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string Name;
        public string Producer;
        public int BulletsNum;

        public Weapon(string name,string producer,int bulletsNum) { 
            Name = name;
            Producer = producer;
            BulletsNum = bulletsNum;
        }

        public void Shoot()
        {
            Console.WriteLine("Shooting");
            BulletsNum--;
        }
    }
}
