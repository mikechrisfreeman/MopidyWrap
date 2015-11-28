using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace MopidyWrap.Models
{
    [DataContract]
    public class MopidyTracklistItem
    {
        [DataMember]
        public MopidyTrack track { get; set; }
        [DataMember]
        public string __model__ { get; set; }
        [DataMember]
        public int tlid { get; set; }

    }
}
