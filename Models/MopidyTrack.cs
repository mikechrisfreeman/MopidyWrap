using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Models
{
    [DataContract]
    public class MopidyTrack
    {
        [DataMember]
        public MopidyAlbum album { get; set; }
        [DataMember]
        public string __model__ { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int disc_no { get; set; }
        [DataMember]
        public string uri { get; set; }
        [DataMember]
        public int length { get; set; }
        [DataMember]
        public int track_no { get; set; }
        [DataMember]
        public List<MopidyArtist> artists { get; set; }
        [DataMember]
        public string data { get; set; }
        [DataMember]
        public int bitrate { get; set; }
               
    }
}
