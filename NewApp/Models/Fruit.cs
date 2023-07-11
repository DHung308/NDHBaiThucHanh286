using System.ComponentModel.DataAnnotations;

public class Fruit
{
    [Key]
    public string? Name { get; set; }

    public int SoLuong { get; set; }

    public void Nhapdulieu()
    {
        System.Console.WriteLine("Tên Hoa Quả là :");
        Name = System.Console.ReadLine();
        System.Console.WriteLine("Số lượng =");
        SoLuong = Convert.ToInt32(Console.ReadLine());
    }

    public void Hienthi()
    {
        System.Console.WriteLine("Hoa qua: {0} - So luong : {1} Kg" ,Name, SoLuong );
    }
}