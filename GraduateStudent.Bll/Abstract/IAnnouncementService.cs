using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Bll.Abstract
{
   public interface IAnnouncementService
    {
        List<Announcement> GetAll();

        Announcement GetById(int id);
    }
}
