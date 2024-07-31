namespace CS_Inherit_StudentManager;
class Manager
{
    public static Student ManagerStudent()
    {
        Console.WriteLine("Manager's student details");
        string name = GetString("Enter name student");
        int age = GetInt("Enter age student");
        string address = GetString("Enter address student");
        string studentId = GetString("Enter ID student");
        string major = GetString("Enter major student");
        return new Student(name, age, address, studentId, major);
    }
    public static Teacher ManagerTeacher()
    {
        Console.WriteLine("Manager's teacher details");
        string name = GetString("Enter name teacher");
        int age = GetInt("Enter age teacher");
        string address = GetString("Enter address teacher");
        string teacherId = GetString("Enter ID teacher");
        string subject = GetString("Enter subject teacher");

        return new Teacher(name, age, address, teacherId, subject);
    }
    private static string GetString(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    private static int GetInt(string prompt)
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        return result;
    }
}