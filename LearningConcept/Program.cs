// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

student student1 = new student();
student1.age = 15;
student1.teacher.salary = 1000;

Console.WriteLine("Student 1 Salary " + student1.teacher.salary); 

student student2 = student1.shallowcopy();

Console.WriteLine("Student 1 Salary " + student2.teacher.salary);

student2.teacher.salary = 2000;

Console.WriteLine("Student 2 Salary " + student2.teacher.salary);
Console.WriteLine("Student 1 Salary " + student1.teacher.salary);


student student3;
//student3 =student1.GetClone()

// Hi This is Test





class student
{
    public int age { get; set; }
    public Teacher teacher{ get; set; }


    public student()
    {
        age = 20;
        teacher = new Teacher();
    }

    public student shallowcopy()
    { 
    
         return (student) this.MemberwiseClone();
    }
}

class Teacher
{
    public int salary { get; set; }
}



