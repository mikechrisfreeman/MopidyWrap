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
    public class MopidyGetState : AMopidyQuery, IMopidyQuery
    {
        [DataMember]
        public string method
        {
            get
            {
                return "core.playback.get_state";
            }

            set
            {
                
            }
        }
    }
}
