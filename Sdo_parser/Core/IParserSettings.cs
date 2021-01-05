using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdo_parser.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }

        int StartPion { get; set; }
        int EndPion { get; set; }
    }
}
