using GraduateStudent.Core.DataAccess;
using GraduateStudent.Dal.Abstract;
using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Dal.Concrete.EntityFramework
{
   public class EfAnnouncementDal : BaseRepository<Announcement, GraduateStudentContext>, IAnnouncementDal
    {

    }
}
