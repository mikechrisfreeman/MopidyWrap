using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Models;

namespace MopidyWrap.Abstract
{
    [DataContract]
    public abstract class AMopidyResponse
    {
        [DataMember]
        public string jsonrpc { get; set; }

        [DataMember]
        public int? id { get; set; }

        [DataMember]
        public MopidyError Error { get; set; }
    }
}
