using System.Xml.Linq;

namespace PersonSpace;

class Person
{
     protected string Name { get; set; }
     protected int Age { get; set; }

    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void GetDetails()
    {
        Console.WriteLine("\nName="+Name+"\nAge="+Age);
    }
}
class Teacher: Person
{
    int Salary { get; set; }
    public Teacher(string name,int age,int salary):base(name,age)
    {            
        Salary = salary;
    }

    public override void GetDetails()
    {
        Console.WriteLine("\nName=" + Name + "\nAge=" + Age+"\nSalary="+ Salary);
    }
}
class Student1 : Person
{
    int RollNo { get; set; }
    public Student1(string name, int age, int rollno) : base(name, age)
    {
        RollNo = rollno;
    }

    public override void GetDetails()
    {
        Console.WriteLine("\nName=" + Name + "\nAge=" + Age + "\nRollNo=" + RollNo);
    }
}
