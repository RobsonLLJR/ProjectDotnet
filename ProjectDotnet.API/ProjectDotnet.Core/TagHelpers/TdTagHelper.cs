using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjectDotnet.Core.TagHelpers
{
    [HtmlTargetElement("td", Attributes = "asp-for")]
    public class TdTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (For.Model is object valor)
            {
                if (For.Metadata.ModelType == typeof(bool) && bool.TryParse(valor.ToString(), out bool resultado))
                    output.Content.Append(resultado ? "Sim" : "Não");
                else if (For.Metadata.DisplayFormatString is string formato)
                    output.Content.AppendFormat(formato, valor);
                else
                    output.Content.Append(valor.ToString());
            }

            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
