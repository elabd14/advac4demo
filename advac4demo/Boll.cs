using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo
{
    internal class Boll
    {
        public int Id { get; set; }

        private Location location;

        public Location locations
        {
            get { return location; }

        
            
            
            
           
            set 
            {
                if (!value.Equals( location))
                {
                    location = value;
                    BollLoctionChanged.Invoke();
                }
        }   }  
        
                                  
        public event Action? BollLoctionChanged;
        public override string ToString()
        {
   
        return $"{Id}.location={location}";
        }


    }
}
