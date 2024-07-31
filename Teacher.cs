namespace CS_Inherit_StudentManager;
class Teacher : Person
{
    public string TeacherID { get; set; }
    public string Subject { get; set; }
    public Teacher(string name, int age, string address, string teacherId, string subject) : base(name, age, address)
    {
        TeacherID = teacherId;
        Subject = subject;
    }
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Teacher ID: {TeacherID}");
        Console.WriteLine($"Subject: {Subject} Dang day");
        
    }
}