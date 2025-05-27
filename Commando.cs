using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        private string Name;

        private string CodeName;

        public string[] Tools;

        public string Status;

        public Commando(string name,string codeName, string[] tools,string status)
        {
            Name = name; 
            CodeName = codeName;
            Tools = tools;
            Status = status;
        }

        public string SayName(string commanderRank)
        {
            switch (commanderRank)
            {
                case "General":
                    return Name;
                case "Colonel":
                    return CodeName;
                default:
                    return "Classified";
            }
        }

        public void Walk()
        {
            Console.WriteLine("The soldier walks");
            Status = "Walk";         
        }

        public void Hide()
        {
            Console.WriteLine("The soldier hidden");
            Status = "Hidden";
        }

        public void Attack()
        {
            Console.WriteLine($"The soldier {CodeName} Attacks");
        }


    }
}
