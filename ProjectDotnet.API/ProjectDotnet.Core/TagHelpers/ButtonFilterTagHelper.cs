using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjectDotnet.Core.TagHelpers
{
    public class ButtonFilterTagHelper(IconHTMLTagHelper iconeHTML) : TagHelper
    {
        protected readonly IconHTMLTagHelper _iconHTML = iconeHTML;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            _iconHTML.Nome = "funnel";
            output.Content.AppendHtml(_iconHTML);
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.Add("class", "btn btn-dark btn-sm text-nowrap");
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "button";

            if (string.IsNullOrEmpty(Text))
            {
                output.Attributes.Add("data-bs-toggle", "tooltip");
                output.Attributes.Add("title", "Filter");
            }
            else
                output.Content.AppendHtmlLine(Text);
        }

        public string Text { get; set; } = "&nbsp;Filtrar";
    }
}
