using System;
using System.ComponentModel.DataAnnotations;

class Student
{
    private int _marks;
    public int Marks
    {
        get;
        set
        {
            if(value>=0 && value <= 100)
            {
                this._marks=value;
            }
            else
            {
                Console.WriteLine("Invalid Marks");
            }
        }
    }

    public void Display()
    {
        Console.WriteLine(this._marks);
    }
    public static void Main(string[] args)
    {
        Student s1=new Student();
        Console.WriteLine("Enter Marks: ");
        int m = int.Parse(Console.ReadLine());
        s1.Marks=m;
        s1.Display();
    }

}