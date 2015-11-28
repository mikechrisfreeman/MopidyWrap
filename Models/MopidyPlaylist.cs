using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Models
{
    [DataContract]
    public class MopidyPlaylist
    {
        [DataMember]
        public string __model__ { get; set; }
        [DataMember]
        public string uri { get; set; }
        [DataMember]
        public List<MopidyTrack> tracks { get; set; }
    }
}
