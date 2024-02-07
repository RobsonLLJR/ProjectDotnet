using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjectDotnet.Core.TagHelpers
{
    public class InputFilterTagHelper(IHtmlGenerator generator) : InputTagHelper(generator)
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.Attributes.SetAttribute("class", "form-control form-control-sm me-2");
            output.TagName = "input";

            if (!output.Attributes.ContainsName("placeholder") && For != null)
                output.Attributes.Add("placeholder", For.Metadata.DisplayName ?? For.Metadata.Name);

            output.TagMode = TagMode.SelfClosing;
        }
    }
}
