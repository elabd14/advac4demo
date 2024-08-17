using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo
{
    internal class Player
    {

        public string PlayerName { get; set; }
        public string TeamName  { get; set; } 
        public void Run()
        {
            Console.WriteLine($"the player {PlayerName} is runing");

                
        }
    }
}
