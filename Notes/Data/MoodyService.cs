using System.Reflection;

namespace Notes.Data
{
    public class MoodyService
    {
        public Moody? Md { get; set; }

        private List<MoodyData> Notes { get; set; } = new List<MoodyData>() { new MoodyData() { Text = "Example", Id = 0, Title = "Titelx" } };

        public void AddToNotes(MoodyData note)
        {
            foreach (var m in Notes)
            {
                if (m.Id == note.Id)
                {
                    m.Text = note.Text;
                    Console.WriteLine(m.Text);
                    return;
                }
            }
            Notes.Add(note);
        }

        public List<MoodyData> GetNotes()
        {
            return Notes;
        }
    }
}
