namespace Eyebrow.Repository.Entites
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Statu { get; set; }
        public DateTime Create_Time { get; set; }
    }
}