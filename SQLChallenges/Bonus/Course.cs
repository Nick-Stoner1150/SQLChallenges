using System.Collections.Generic;

namespace SQLChallenges.Bonus
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public List<Student> Students { get; set; }
    }
}