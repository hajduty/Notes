namespace Notes.Data
{
    public class Moody
    {
        public MoodyData ActiveNote { get; set; } = new();
    }

    public class MoodyData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = "# hello world";
        public string Title { get; set; } = "Untitled";
    }
}
