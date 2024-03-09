namespace Notes.Data
{
  public class Moody
  {
    public int? ActiveNoteId { get; set; }

    public MoodyData? ActiveNote { get; set; }
  }

  public class MoodyData
  {
    public int Id { get; set; } = 0;
    public string Text { get; set; } = "";
  }
}
