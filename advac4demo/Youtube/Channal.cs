using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo.Youtube
{
    internal class Channal
    {
        public string ChannalName {  get; set; }    
        public List<Video> videos {  get; set; }
    

        public void AddVideo(Video video)
        {
            videos.Add(video);

            Uploadvideo.Invoke(video,this);
        }

        public event Action <Video,Channal> ? Uploadvido;

        public event Action Uploadvideo;
        public override string ToString()
        {
            return $"ChannalName:{ChannalName}";
                
        }
    }
}
