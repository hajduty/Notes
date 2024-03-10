using Markdig;

namespace Notes.Data
{
    public class MdService
    {
        public static string ConvertToHtml(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .Build();

            string html = Markdown.ToHtml(markdown, pipeline);
            return html;
        }
    }
}
