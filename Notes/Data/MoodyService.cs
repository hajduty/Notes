using System.Reflection;
using System.Xml.Linq;

namespace Notes.Data
{
    public class MoodyService
    {
        public Moody? Md { get; set; }

        private List<MoodyData> Notes { get; set; } = new List<MoodyData>();

        public void AddToNotes(MoodyData note)
        {
            Notes.Add(note);
        }

        public void UpdateNote(MoodyData md)
        {
            var index = Notes.FindIndex(e => e.Id == md.Id);

            if (index == -1)
                return;

            Notes[index] = md;

            Console.WriteLine($"{Notes[index]}");
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
