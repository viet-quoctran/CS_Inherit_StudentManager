namespace CS_Inherit_StudentManager;
class Student : Person 
{
    public string StudentId { get; set; }
    public string Major { get; set; }
    public Student(string name, int age, string address, string studentId, string major) : base(name, age, address)
    {
        StudentId = studentId;
        Major = major;
    }
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine("Major : " + Major + " Dang hoc");
    }
}