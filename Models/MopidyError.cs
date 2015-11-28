using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Models
{
    [DataContract]
    public class MopidyError
    {
        [DataMember]
        public string message { get; set; }
        [DataMember]
        public int code { get; set; }
        [DataMember]
        public Dictionary<string, string> data { get; set; }

    }
}
