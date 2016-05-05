using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperLibrary
{
    [HtmlTargetElement("he", Attributes = "[firstatt]")]
    public class FirstTagHelper : TagHelper
    {
        public FirstTagHelper()
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("firstatt");
            output.PreContent.Append("FIRST ATTR ");
        }
    }
}
