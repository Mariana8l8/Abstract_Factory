using Abstract_Factory.Interfaces;
using Abstract_Factory.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Sessions
{
    public class Practice : Session
    {
        public Practice(TimeCell time, string room, ITeacher teacher) : base(time, room, teacher) { }
        protected override void EnsureRole(ITeacher teacher)
        {
            if (teacher is not IPracticalCapable) throw new ArgumentException("Teacher must be lecture-capable.");
        }
    }
}
