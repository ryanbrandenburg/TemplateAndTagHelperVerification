using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersTests
{
    [HtmlTargetElement("he")]
    public class IntValueTagHelper : TagHelper
    {
        [HtmlAttributeName("int-value")]
        public int Int { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(Int.ToString());
        }
    }
    
    [HtmlTargetElement("he")]
    public class EnumTagHelper : TagHelper
    {
        public CustomEnum Enum { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append("It was " + Enum.ToString() + " all along!");
        }
    }

    [HtmlTargetElement("he", Attributes = "[remove-tag-helper]")]
    public class RemovedTagHelper : TagHelper
    {
    }

    [HtmlTargetElement("he", Attributes = "[required-attribute],[needed]")]
    public class RequiredAttributeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append("Required attribute was there!");
        }
    }

    [HtmlTargetElement("he")]
    public class ContentTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(" Boy that sure was content!");
        }
    }

    [HtmlTargetElement("he")]
    public class BoolTagHelper : TagHelper
    {
        public bool BoolAttribute { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(" good bool!");
        }
    }

    [HtmlTargetElement("he", Attributes = "[li-parent]", ParentTag = "li")]
    public class LiParentTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(" The parent should have been a li");
        }
    }

    [HtmlTargetElement("he", Attributes = "[a-child]")]
    [RestrictChildren("a")]
    public class AChildTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(" The child should have been an a");
        }
    }

    [HtmlTargetElement("he")]
    public class DontFindTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        public string NotAnAttribute { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(" This should never show.");
        }
    }

    public enum CustomEnum
    {
        Charles,
        Steve,
        Andrew
    }
}
