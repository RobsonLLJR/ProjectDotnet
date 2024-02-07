using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjectDotnet.Core.TagHelpers
{
    public class TableTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var classes = "table table-striped table-hover table-bordered caption-top dt-responsive nowrap";

            if (output.Attributes.ContainsName("class"))
            {
                var values = classes.Split(" ").Union(output.Attributes["class"].Value.ToString().Split(" "));

                classes = string.Join(" ", values);
            }

            output.Attributes.SetAttribute("class", classes);
        }
    }
}
