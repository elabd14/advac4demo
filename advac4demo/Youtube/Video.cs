using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo.Youtube
{
    internal class Video
    {
        public string Tittle { get; set; }
        public string Descrition { get; set; }

        public override string ToString()
        {
            return $"Tittle:{Tittle},Descrition: {Descrition}";
        }
    }
}
