using Abstract_Factory.Courseworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Sessions
{
    public class CourseEnrollment
    {
        public string CourseName { get; }
        public Session Lecture { get; }
        public Session Practical { get; }
        public Coursework Coursework { get; }
        public string LectureRoom {  get; }
        public string PracticalRoom {  get; }


        public CourseEnrollment(string courseName, Session lecture, Session practical, Coursework coursework, string lectureRoom, string practicalRoom)
        {
            CourseName = string.IsNullOrWhiteSpace(courseName) ? throw new ArgumentException("Course name required") : courseName;
            Lecture = lecture ?? throw new ArgumentNullException(nameof(lecture));
            Practical = practical ?? throw new ArgumentNullException(nameof(practical));
            Coursework = coursework ?? throw new ArgumentNullException(nameof(coursework));
            LectureRoom = string.IsNullOrWhiteSpace(lectureRoom) ? throw new ArgumentNullException(nameof(lectureRoom)) : lectureRoom;
            PracticalRoom = string.IsNullOrWhiteSpace(practicalRoom) ? throw new ArgumentNullException(nameof(practicalRoom)) : practicalRoom;
        }
    }
}
