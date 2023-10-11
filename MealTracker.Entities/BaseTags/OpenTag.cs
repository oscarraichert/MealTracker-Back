namespace HtmlBuilder.Entities.BaseTags
{
    public abstract class OpenTag : ITag
    {
        protected abstract string TagName { get; }

        public string BuildTag()
        {
            return $"<{TagName}>";
        }
    }
}
