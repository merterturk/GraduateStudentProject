using GraduateStudent.Bll.Abstract;
using GraduateStudent.Dal.Abstract;
using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Bll.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }
        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.Get(a => a.Id == id);
        }
    }
}
