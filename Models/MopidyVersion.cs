using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MopidyWrap.Abstract;

namespace MopidyWrap.Models
{
    public class MopidyVersion : AMopidyResponse
    {
        public string version { get; set; }
    }
}
