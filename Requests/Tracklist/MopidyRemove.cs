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
    [DataContract]
    public class MopidyRemove : AMopidyQuery, IMopidyQuery
    {
        [DataMember]
        public string method
        {
            get
            {
                return "core.tracklist.remove";
            }

            set
            {
               
            }
        }

        public string uri { get; set; }
        public List<string> uris { get; set; }
        public MopidyParameters Params { get; set; }


        [DataMember(Name = "params")]
        public MopidyParameters PARAMS
        {
            get
            {
                if (Params != null)
                    return Params;
                Params = new MopidyParameters();
                Params.criteria = new MopidyCriteria();
                if (!string.IsNullOrEmpty(uri))
                {
                    Params.criteria.URI = uri;
                }
                if(uris != null && uris.Count > 0)
                {
                    Params.criteria.URIS = uris;
                }
                return Params;
            }
            private set { }
        }
    }
}
