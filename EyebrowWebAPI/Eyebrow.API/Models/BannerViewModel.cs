namespace Eyebrow.API.Models
{
    public class BannerViewModel
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string URL { get; set; }
        public bool? Statu { get; set; }
        public int Order { get; set; }
    }
}
