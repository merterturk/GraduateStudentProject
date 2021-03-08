using GraduateStudent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Entities.Concrete
{
    public class Announcement : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

    }
}
