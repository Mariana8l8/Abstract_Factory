using Abstract_Factory.Courseworks;
using Abstract_Factory.Interfaces;
using Abstract_Factory.Other;
using Abstract_Factory.Sessions;
using Abstract_Factory.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public class ProgrammingCourseFactory : ICourseFactory
    {
        public string CourseName => "Programming";
        public Session CreateLecture(TimeCell time, string room, Lecturer lecturer) => new ProgrammingLecture(time, room, lecturer);
        public Session CreatePractical(TimeCell time, string room, Assistant assistant) => new ProgrammingPractice(time, room, assistant);
        public Coursework CreateCoursework(ISuperviseCapable supervisor) => new ProgrammingCoursework("Programming Coursework", new GitHubRepoDefense(), supervisor);
    }
}
