using Abstract_Factory.Interfaces;
using Abstract_Factory.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Sessions
{
    public class DatabasesLecture : Lecture
    {
        public DatabasesLecture(TimeCell time, string room, ITeacher teacher) : base(time, room, teacher) { }
    }
}
