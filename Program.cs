namespace CS_Inherit_StudentManager;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Which option do you want to choose?");
            Console.WriteLine("1. Enter infomation students");
            Console.WriteLine("2. Enter infomation teachers");
            Console.WriteLine("3. Exit");
            int option;
            while(!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
            {
                Console.WriteLine("Invalid option. Please choose again.");
            }
            switch (option)
            {
                case 1:
                    var student = Manager.ManagerStudent();
                    student.DisplayStatus();
                    break;
                case 2:
                    var teacher = Manager.ManagerTeacher();
                    teacher.DisplayStatus();
                    break;
                case 3:
                    return;
                default:
                    break;
            }
        }

    }
}
