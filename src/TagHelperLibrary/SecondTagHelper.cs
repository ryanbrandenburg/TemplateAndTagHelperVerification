using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperLibrary
{
    [HtmlTargetElement("he", Attributes = "[secondatt]")]
    public class SecondTagHelper : TagHelper
    {
        public SecondTagHelper()
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PostContent.Append(" Second Attr!");
        }
    }
}
