using AngleSharp.Html.Dom;

namespace Sdo_parser.Core
{
    interface IParser<T> where T: class
    {
        T Parse(IHtmlDocument document);
    }
}
