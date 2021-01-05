using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdo_parser.Core.Sdo
{
    class SdoSettings : IParserSettings
    {
        public string BaseUrl { get; set ; }
        public string Prefix { get; set; }
        public int StartPion { get; set; }
        public int EndPion { get; set; }
    }
}
