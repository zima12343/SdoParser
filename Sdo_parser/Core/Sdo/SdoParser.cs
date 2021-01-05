using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdo_parser.Core.Sdo
{
    class SdoParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            List<string> list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("que multichoice deferredfeedback notanswered"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
