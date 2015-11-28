using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Models
{
    [DataContract]
    public class MopidyAlbum
    {
        [DataMember]
        public string date { get; set; }
        [DataMember]
        public string __model__ { get; set; }
        [DataMember]
        public List<MopidyArtist> artists { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string uri { get; set; }
    }
}
