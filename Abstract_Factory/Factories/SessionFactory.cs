using Abstract_Factory.Interfaces;
using Abstract_Factory.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public abstract class SessionFactory
    {
        public Session CreateSession(TimeCell time, string room, ITeacher teacher) => Make(time, room, teacher);
        public abstract Session Make(TimeCell time, string room, ITeacher teacher);
    }
}
