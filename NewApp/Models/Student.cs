using System.ComponentModel.DataAnnotations;

namespace NewApp.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }
    public string FullName { get; set; }

    public int Age {get; set;}

    public void Nhapdulieu()
    {
        System.Console.WriteLine("StudentID =");
        StudentID =Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("FullName =");
        FullName = System.Console.ReadLine();
        System.Console.WriteLine("Age =");
        Age =Convert.ToInt32(Console.ReadLine());
    }

    public void Hienthi()
    {
        System.Console.WriteLine("Sinh vien : {0} - Ma so sinh vien : {1}",FullName, StudentID);
    }
    public int GetYearOfBirth(int age)
    {
        int GetYearOfBirth = 2023 - age;
        return GetYearOfBirth;
    }

    public Student(int id, string name)
    {
        StudentID = id;
        FullName = name;

    } 
    public string TinhTuoi()
    {
        return TinhTuoi();
    }
}
