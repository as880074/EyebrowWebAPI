using Eyebrow.Repository.Entites;

namespace Eyebrow.Service.Interface
{
    public interface IAnnouncement
    {
        public List<Announcement> GetAnnouncements();
        public void CreateAnnouncements(Announcement data);
    }
}