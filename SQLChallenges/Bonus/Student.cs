namespace SQLChallenges.Bonus
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Professor Professor { get; set; }
    }
}