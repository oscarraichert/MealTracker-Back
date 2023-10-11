using HtmlBuilder.Entities.BaseTags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder.Entities.Tags
{
    public class Input : OpenTag
    {
        protected override string TagName => "input";

        public Input()
        {
            
        }
    }
}
