using System;

namespace MathApp.Models
{
    public class GiaiPt
    {
        public static string PhuongTrinh(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình vô số nghiệm.";
                else
                    return "Phương trình vô nghiệm.";
            }
            else
            {
                
                double x = -b / a;
                return $"Nghiệm của phương trình là x = {x}.";
            }
        }

        public static string PhuongTrinh(double a, double b, double c)
        {
            if (a == 0)
            {
                return PhuongTrinh(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                    return "Phương trình vô nghiệm.";
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    return $"Phương trình có nghiệm kép x = {x}.";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}.";
                }
            }
        }
    }
}
