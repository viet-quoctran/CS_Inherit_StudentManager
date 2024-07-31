namespace CS_Inherit_StudentManager;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
    }
     
}