using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int EmployeeID { get; set; }
    public string FullName { get; set; }

    public int Age { get; set; }

    public int Luong { get; set; }

    public void Nhapdulieu()
    {
        System.Console.WriteLine("Employee =");
        EmployeeID =Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("FullName =");
        FullName = System.Console.ReadLine();
        System.Console.WriteLine("Tuoi =");
        Age = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Luong =");
        Luong = Convert.ToInt32(Console.ReadLine());
    }

    public void Hienthi()
    {
        System.Console.WriteLine("Nhan vien: {0} - Ma Nhan vien : {1} - Tuoi :{3}- Luong {4}",FullName, EmployeeID, Age, Luong );
    }
}
