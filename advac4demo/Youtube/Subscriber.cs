using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo.Youtube
{
    internal class Subscriber
    {
        private object ChannalName;

        public string SubscriberNamme {  get; set; }

        public void Notify(Video video,Channal channal)
        {
            Console.WriteLine(value: $"{ChannalName}is  add a new video  !!,{SubscriberNamme}\n {video }  ");
        }
        public override string ToString()
        {
            return $"subscriberName:{SubscriberNamme}";
        }
    }
}
