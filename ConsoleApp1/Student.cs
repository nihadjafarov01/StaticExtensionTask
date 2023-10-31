using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Student
{
    public static int id;
    public int Id { get; }
    public  string fullName;
    public  string FullName 
    {
        get => fullName;
        set
        {
            value = value.Trim();
            int index = 0;
            int counter = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ')
                {
                    index = i;
                    counter++;
                }
            }
            if (counter == 1) 
            {
                if (value[0] == Char.ToUpper(value[0]) && value[index + 1] == Char.ToUpper(value[index + 1]))
                {
                    fullName = value;
                }
            }
            else
            {
                fullName = null;
            }
        }
    }
    public string groupNo;
    public string GroupNo 
    {
        get => groupNo;
        set
        {
            if (value[0] == Char.ToUpper(value[0]))
            {
                if (Convert.ToInt32(value.Substring(1)) > 99 && Convert.ToInt32(value.Substring(1)) < 1000)
                {
                    groupNo = value;
                    return;
                }
            }
            groupNo = null;
        }
    }
    public int age;
    public int Age 
    { 
        get => age; 
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                age = 0;
            }
        }
    }

    public static bool CheckGroupNo(string groupNo)
    {
        if (String.IsNullOrEmpty(groupNo))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool CheckFullname(string fullName)
    {
        if (String.IsNullOrEmpty(fullName))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public Student(/*string fullName, string groupNo, int age*/) 
    {
        //FullName = fullName;
        //GroupNo = groupNo;
        //Age = age;
        id++;
        Id = id;
    }
    public override string ToString()
    {
        return $"{Id} --> {FullName}, {GroupNo}, {Age}";
    }
}
