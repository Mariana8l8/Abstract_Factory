using Abstract_Factory.Interfaces;
using Abstract_Factory.Other;
using Abstract_Factory.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public class PracticeFactory : SessionFactory
    {
        public override Session Make(TimeCell time, string room, ITeacher teacher) => new Practice(time, room, teacher);
    }
}
