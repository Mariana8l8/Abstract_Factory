using Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Teachers
{
    public class ExternalMentor : ITeacher, ISuperviseCapable
    {
        public string Name { get; }
        public ExternalMentor(string name) => Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException("Name required") : name; 
    }
}
