using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Requests
{
    [DataContract]
    public class MopidyParameters
    {
        [DataMember(EmitDefaultValue = false)]
        public string uri { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int tlid { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string tl_track { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public MopidyCriteria criteria { get; set; }
    }
}
