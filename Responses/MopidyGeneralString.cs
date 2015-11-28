using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Abstract;

namespace MopidyWrap.Responses
{
    [DataContract]
    public class MopidyGeneralString : AMopidyResponse
    {
        [DataMember]
        public string result { get; set; }
    }
}
