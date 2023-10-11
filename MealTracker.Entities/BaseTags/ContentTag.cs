namespace HtmlBuilder.Entities.BaseTags
{
    public abstract class ContentTag : ITag
    {
        protected abstract string TagName { get; }

        public abstract ITag[] Tags { get; set; }

        public string BuildTag()
        {
            return $"<{TagName}>{string.Join('\n', Tags.Select(x => x.BuildTag()))}</{TagName}>";
        }
    }
}
