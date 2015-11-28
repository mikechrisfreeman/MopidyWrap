using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Abstract;

namespace MopidyWrap.Models
{
    [DataContract]
    public class MopidyTracklist : AMopidyResponse
    {
        [DataMember(Name = "result")]
        public List<MopidyTracklistItem> items { get; set; }
    }
}
