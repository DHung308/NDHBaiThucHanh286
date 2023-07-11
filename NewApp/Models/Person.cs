namespace NewApp.Models;
public class Person
{
    public int PersonID { get; set; }
    public String ? FullName { get; set; }

    public Person()
    {
        PersonID = 2000;
        FullName = "Họ và tên mặc định";

    }

}