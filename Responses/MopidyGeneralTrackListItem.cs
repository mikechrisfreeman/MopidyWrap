using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Abstract;
using MopidyWrap.Models;

namespace MopidyWrap.Responses
{
    [DataContract]
    public class MopidyGeneralTrackListItem : AMopidyResponse
    {
        [DataMember(Name = "result")]
        public MopidyTracklistItem track { get; set; }
    }
}
