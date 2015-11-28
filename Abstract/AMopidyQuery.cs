using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MopidyWrap.Abstract
{
    [DataContract]
    public abstract class AMopidyQuery
    {
        [DataMember]
        public string jsonrpc { get { return "2.0"; } private set { } }

        [DataMember]
        public int id { get { return 1; } private set { } }

    }
}
