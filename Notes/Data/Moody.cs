namespace Notes.Data
{
    public class Moody
    {
        public MoodyData ActiveNote { get; set; } = new();
    }

    public class MoodyData
    {
        public int Id { get; set; } = 0;
        public string Text { get; set; } = "# hello world";
        public string Title { get; set; } = "Untitled";
    }
}
