using Eyebrow.Repository;
using Eyebrow.Repository.Entites;
using Eyebrow.Service.Interface;

namespace Eyebrow.Service
{
    public class AnnouncementService:IAnnouncement
    {
        private readonly DataContext _db;
        public AnnouncementService(DataContext db)
        {
            _db = db;
        }
        public List<Announcement> GetAnnouncements()
        {
            return _db.Announcement.ToList();
        }
        public void CreateAnnouncements(Announcement data)
        {
            data.Create_Time = DateTime.Now;
            _db.Announcement.Add(data);
            _db.SaveChanges();
        }
    }
}