using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlBuilder.Entities.BaseTags;

namespace HtmlBuilder.Entities.Tags
{
    public class Div : ContentTag
    {
        public override ITag[] Tags { get; set; }
        protected override string TagName => "div";

        public Div(params ITag[] tags)
        {
            Tags = tags;
        }
    }
}
