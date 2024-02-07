using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjectDotnet.Core.TagHelpers
{
    [HtmlTargetElement("th", Attributes = "asp-for")]
    public partial class ThTagHelper : TagHelper
    {

        [HtmlAttributeName("asp-display-for")]
        public ModelExpression Display { get; set; }

        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }
        public bool NotClassif { get; set; }

        public override void Init(TagHelperContext context)
        {
            base.Init(context);

            Display ??= For;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var text = Display.Metadata.Name;
            var textTh = Display.Metadata.DisplayName ?? text;
            output.PreContent.AppendHtml("<div class=\"align-items-center\">");
            output.Content.AppendHtml($"<span>{textTh}</span>");
            output.PostContent.AppendHtml("</div>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }

    }
}
