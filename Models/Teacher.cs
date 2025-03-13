namespace Dependency_Injection_Practice.Models
{
    public class Teacher:ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher()
        {
            FirstName = "Furkan";
            LastName = "Cengiz";
        }

        public string GetInfo()
        {
            return $"Teacher: {FirstName} - {LastName}";
        }
    }
}
