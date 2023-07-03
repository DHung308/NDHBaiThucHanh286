//Nhập tên
Console.WriteLine("Nhập họ và tên:");
string hoTen = Console.ReadLine();

Console.WriteLine("Nhập tuổi:");
int tuoi = Convert.ToInt32(Console.ReadLine());

string ketQua = string.Format("Tên bạn là {0}, {1} tuổi", hoTen, tuoi);
Console.WriteLine(ketQua);
