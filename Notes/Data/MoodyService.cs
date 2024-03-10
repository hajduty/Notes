using System.Reflection;
using System.Xml.Linq;

namespace Notes.Data
{
    public class MoodyService
    {
        public Moody? Md { get; set; }

        private List<MoodyData> Notes { get; set; } = new List<MoodyData>() { new MoodyData() { Text = "Example", Id = 0, Title = "Titelx" } };

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

        public List<MoodyData> GetNotes()
        {
            return Notes;
        }

        public void SetNotes(List<MoodyData> notes)
        {
            Notes = notes;
        }
    }
}
