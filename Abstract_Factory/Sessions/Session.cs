using Abstract_Factory.Interfaces;
using Abstract_Factory.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_Factory
{
    public abstract class Session
    {
        public TimeCell Time { get; }
        public string Room { get; }
        public ITeacher Teacher { get; }


        protected Session(TimeCell time, string room, ITeacher teacher)
        {
            Time = time;
            Room = string.IsNullOrWhiteSpace(room) ? throw new ArgumentException("Name required") : room;
            Teacher = teacher ?? throw new ArgumentNullException(nameof(teacher));
            EnsureRole(teacher);
        }


        protected abstract void EnsureRole(ITeacher teacher);
    }
}
