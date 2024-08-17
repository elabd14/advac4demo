using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo
{
    internal class Refre
    {
        public string RefreeName {  get; set; } 
         public void look(Boll boll)
        {
            Console.WriteLine($"Refree {RefreeName} is looking the boll:{boll}");
        }
    }
}
