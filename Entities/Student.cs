namespace Entities
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public string UserName { get; set; }
        public const string EMail = "@itu.edu.tr";

        public Mathemathics Mathemathics { get; set; }

        public Student(string name)
        {
            Name = name;
            StudentNumber = 0;
            UserName = "No UserName";
            Mathemathics = new Mathemathics();

        }
    }
}
