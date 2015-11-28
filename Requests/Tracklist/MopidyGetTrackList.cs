using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MopidyWrap.Abstract;
using MopidyWrap.Interfaces;
using System.Runtime.Serialization;

namespace MopidyWrap.Requests.Tracklist
{
    public class MopidyGetTrackList : AMopidyQuery, IMopidyQuery
    {
        [DataMember]
        public string method
        {
            get
            {
                return "core.tracklist.get_tl_tracks";
            }

            set
            {

            }
        }
    }
}
