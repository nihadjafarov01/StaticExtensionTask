using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        //Student student = new Student();
        //   Console.WriteLine(student); ("Nihad  Jafarov", "P101", 20)
        char option = '0';
        Console.WriteLine("1. Create student \nq. quit");
        do
        {
            Console.WriteLine("1, 2, 3 or q");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    Student student = new Student();
                    do
                    {
                        Console.Write("Fullname: ");
                        student.FullName = Console.ReadLine();
                    }
                    while (Student.CheckFullname(student.FullName) == false);
                    do
                    {
                        Console.Write("Group no: ");
                        student.GroupNo = Console.ReadLine();
                    }
                    while (Student.CheckGroupNo(student.GroupNo) == false);
                    do
                    {
                        Console.Write("Age: ");
                        student.Age = Convert.ToInt32(Console.ReadLine());
                    }
                    while (student.Age == 0);
                    Console.WriteLine(student);
                    break;
            }
        }
        while (option != 'q');
        //Console.WriteLine(Student.CheckGroupNo(student.GroupNo));
        //Console.WriteLine(Student.CheckFullname(student.FullName));
    }
}