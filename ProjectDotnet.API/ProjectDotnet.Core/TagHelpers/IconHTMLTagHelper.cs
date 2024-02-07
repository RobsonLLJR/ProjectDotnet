using Microsoft.AspNetCore.Html;
using System.Text.Encodings.Web;

namespace ProjectDotnet.Core.TagHelpers
{
    public class IconHTMLTagHelper : IHtmlContent
    {
        public Dictionary<string, string> Atributos { get; set; } = new Dictionary<string, string>();

        public string Class { get; set; } = string.Empty;

        protected string EscreverAtributos()
        {
            if (Atributos.Count == 0)
                return string.Empty;

            return string.Concat(Atributos.Select(a => string.Concat(" ", a.Key, "=\"", a.Value, "\"")));
        }

        public string Nome { get; set; } = string.Empty;

        public void WriteTo(TextWriter writer, HtmlEncoder encoder) =>
            writer.Write($"<i class='{string.Join(" ", string.Concat("bi-", Nome), Class)}'{EscreverAtributos()}></i>");
    }
}
