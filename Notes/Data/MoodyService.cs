namespace Notes.Data
{
    public class MoodyService
    {
        public Moody Md { get; set; } = new();

        public List<MoodyData> Notes { get; set; } = new();

        public void AddToNotes(MoodyData note)
        {  
            Notes.Add(note);
        }

        public void UpdateNote(MoodyData md)
        {
            var element = Notes.FirstOrDefault(e => e.Id == md.Id);

            if (element == null)
                return;

            element = md;
        }
    }
}
