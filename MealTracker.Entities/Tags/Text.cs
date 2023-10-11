using HtmlBuilder.Entities.BaseTags;

namespace HtmlBuilder.Entities.Tags
{
    public record Text(string Content) : ITag
    {
        public string BuildTag()
        {
            return Content;
        }
    }
}
