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
    public class DatabasesCourseFactory : ICourseFactory
    {
        public string CourseName => "Databases";
        public Session CreateLecture(TimeCell time, string room, Lecturer lecturer) => new DatabasesLecture(time, room, lecturer);
        public Session CreatePractical(TimeCell time, string room, Assistant assistant) => new DatabasesPractice(time, room, assistant);
        public Coursework CreateCoursework(ISuperviseCapable supervisor) => new DatabasesCoursework("Database Coursework", new GitHubRepoDefense(), supervisor);
    }
}
