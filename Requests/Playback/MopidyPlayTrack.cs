using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Requests;
using MopidyWrap.Abstract;
using MopidyWrap.Interfaces;

namespace MopidyWrap.Requests.Playback
{
    [DataContract]
    public class MopidyPlayTrack : AMopidyQuery, IMopidyQuery
    {
        [DataMember]
        public string method
        {
            get
            {
                return "core.playback.play";
            }

            set
            {
            }
        }
        public string tl_track { get; set; }
        public int tlid { get; set; }
        public MopidyParameters Params { get; set; }
        [DataMember(Name = "params")]
        public MopidyParameters PARAMS
        {
            get
            {
                Params = new MopidyParameters();
                if (!string.IsNullOrEmpty(tl_track))
                    Params.tl_track = tl_track;
                if (tlid != default(int))
                    Params.tlid = tlid;
                return Params;
            }
            set { }
        }
    }
}
