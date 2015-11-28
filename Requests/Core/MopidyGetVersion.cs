using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Requests;
using MopidyWrap.Abstract;
using MopidyWrap.Interfaces;

namespace MopidyWrap.Requests.Core
{
    [DataContract]
    class MopidyGetVersion : AMopidyQuery, IMopidyQuery
    {
        [DataMember]
        public string method
        {
            get
            {
                return "core.get_version";
            }

            set
            {
                
            }
        }
    }
}
