using Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Teachers
{
    public class Assistant : ITeacher, IPracticalCapable
    {
        public string Name { get; }
        public Assistant(string name) => Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException("Name required") : name;

    }
}
