using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Requests
{
    [DataContract]
    public class MopidyCriteria
    {
        public MopidyCriteria()
        {
            URIS = new List<string>();
        }
        public string URI { get; set; }

        public List<string> URIS { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> uri
        {
            get
            {
                if (!string.IsNullOrEmpty(URI))
                    URIS.Add(URI);
                return URIS;
            }
            private set { } 
        }


    }
}
