internal class Program
{
    private static void Main(string[] args)
    {
        //Khai bao bien kieu string va gan gia tri = Nguyen Duong Hung
        String hoTen = "Nguyen Duong Hung";
        //Khai bao bien kieu in va gan gia tri = 22
        int tuoi = 22;
        Console.WriteLine("Sinh vien {0} - {1} tuoi",hoTen,tuoi);

    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //Khai bao bien kieu string va gan gia tri = Nguyen Duong Hung
        const string hoTen = "Nguyen Duong Hung";
        //khai bao bien kieu int va gan gia tri = 8
        const int namLamViec = 8
        Console.WriteLine("Nhan vien {0} - {1} nam kinh nghiem",hoTen,namLamViec);
    }
}

//Chuyen doi kieu du lieu
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        float b = a;
        System.Console.WriteLine("b =", + b);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
      string str = "123";
      int a =int.Parse(str);
      System.Console.WriteLine("a = " + a);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
      string str = "123"; //gia tri dau vao de chuyen doi
      int ketQua; //bien luu ket qua sau khi chuyen doi
      //bien kiem tra chuyen doi co thanh cong hay khong
      bool kiemTra = false;
      //chuyen doi kieu du lieu
      kiemTra = int.TryParse(str,out(ketQua));
      System.Console.WriteLine("ketQua = " + ketQua);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
      string str ="123";//gia tri dau vao de chuyen doi
      //chuyen doi kieu du lieu string (gia tri = "123")
      //sang kieu du lieu int (gia tri = 123)
      int a = Convert.ToInt32(str);
      System.Console.WriteLine("a =" + a);
    }
}

//Cac toan tu

internal class Program
{
    private static void Main(string[] args)
    {
      int a,b; //khai bao 2 bien so a va b kieu int
      //thong bao cho nguoi nhap vao a
      System.Console.Write("a =" );
      //doc du lieu nhap tu ban phim chuyen sang kieu int va gan cho a
      a = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("b =");
      //doc du lieu nhap tu ban phim chuyen sang kieu int va gan cho b
      b = Convert.ToInt32(Console.ReadLine());
      //in tong a + b ra ngoai man hinh
      System.Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
    }
}

//Cau truc re nhanh
internal class Program
{
    private static void Main(string[] args)
    {
      float a = 10;
      if(a >= 8){
        System.Console.WriteLine("Hoc sinh hoc luc gioi");
      }else if(a >= 6.5){
        System.Console.WriteLine("Hoc sinh hoc luc kha");
      }else if(a >= 5){
        System.Console.WriteLine("Hoc sinh hoc luc trung binh");
      }else if(a >=3.5){
        System.Console.WriteLine("Hoc sinh hoc luc yeu");
      }else{
        System.Console.WriteLine("Hoc sinh hoc luc kem");
      }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        if(a < 0)
        {
            System.Console.WriteLine("{0} la so nguyen am", a);
        }else{
            if(a % 2 = 0){
                System.Console.WriteLine("{0} la so nguyen duong chan", a);
            }else{
                System.Console.WriteLine("{0} la so nguyen duong le", a);
            }
        }
      
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int day = 2;
        switch(day)
        {
            case 1 : System.Console.WriteLine("Chu nhat"); break;
            case 2 : System.Console.WriteLine("Thu 2"); break;
            case 3 : System.Console.WriteLine("Thu 3"); break;
            case 4 : System.Console.WriteLine("Thu 4"); break;
            case 5 : System.Console.WriteLine("Thu 5"); break;
            case 6 : System.Console.WriteLine("Thu 6"); break;
            case 7 : System.Console.WriteLine("Thu 7"); break;
            default :
            System.Console.WriteLine("Khong phai nagy trong tuan");
            break;
        } 
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            System.Console.WriteLine("Vong lap thu {0},i");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        while(a < 10)
        {
            System.Console.WriteLine("Vong lap thu {0}",a);
            //tang a len 1 don vi dde dam bao co luc a >= 10
            //a >= 10 thi vong lap se ket thuc
            a++;
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        do
        {
            System.Console.WriteLine("Vong lap thu {0}",a);
            //tang a len 1 don vi dde dam bao co luc a >= 10
            //a >= 10 thi vong lap se ket thuc
            a++;
        }while(a < 10)
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++)
      {
        if(i == 5) break;
        System.Console.WriteLine("Vong lap thu {0}, i");
      }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++)
      {
        if(i == 5) continue;
        System.Console.WriteLine("Vong lap thu {0}, i");
      }
    }
}   

//Xay dung chuong trinh cho phep nhap tt sinh vien va diem cac mon hoc sinh vien va tinh diem cac mon hoc

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập mã số sinh viên:");
        string maSV = Console.ReadLine();

        Console.WriteLine("Nhập tên sinh viên:");
        string tenSV = Console.ReadLine();

        Console.WriteLine("Nhập điểm môn Toán:");
        double diemToan = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập điểm môn Văn:");
        double diemVan = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập điểm môn Anh:");
        double diemAnh = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập điểm môn Sử:");
        double diemSu = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập điểm môn Địa:");
        double diemDia = double.Parse(Console.ReadLine());

        double diemTrungBinh = (diemToan + diemVan + diemAnh + diemSu + diemDia) / 5;

        Console.WriteLine("Mã số sinh viên: " + maSV);
        Console.WriteLine("Tên sinh viên: " + tenSV);
        Console.WriteLine("Điểm trung bình: " + diemTrungBinh.ToString("0.00"));

        Console.ReadLine();
    }
}
