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
    /// <summary>
    /// Adds either a track or a playlist to 
    /// </summary>
    [DataContract]
    public class MopidyAdd : AMopidyQuery, IMopidyQuery
    {

        [DataMember]
        public string method { get { return "core.tracklist.add"; } set { } }

        public string URI { get; set; }

        private MopidyParameters Params { get; set; }

        [DataMember(Name ="params")]
        public MopidyParameters PARAMS
        {
            get
            {
                Params = new MopidyParameters();
                if (!string.IsNullOrEmpty(URI))
                    Params.uri = URI;
                return Params;
            }
            set { }
        }

    }
}
