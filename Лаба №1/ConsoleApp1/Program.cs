using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.Write("Введите коэффициент А: ");
            string A1 = Console.ReadLine();
            while ((Double.TryParse(A1, out A) == false))
            {
                Console.WriteLine("Некорректный ввод. Введите повторно коэффициент А: ");
                A1 = Console.ReadLine();
            }
            A = Convert.ToDouble(A1);
            Console.Write("Введите коэффициент В: ");
            string B1 = Console.ReadLine();
            while ((Double.TryParse(B1, out B) == false))
            {
                Console.WriteLine("Некорректный ввод. Введите повторно коэффициент В: ");
                B1 = Console.ReadLine();
            }
            B = Convert.ToDouble(B1);
            Console.Write("Введите коэффициент С: ");
            string C1 = Console.ReadLine();
            while ((Double.TryParse(C1, out C) == false))
            {
                Console.WriteLine("Некорректный ввод. Введите повторно коэффициент С: ");
                C1 = Console.ReadLine();
            }
            C = Convert.ToDouble(C1);
            if ((C == 0) && (B == 0) && (A == 0))
            {
                Console.Write("Введены нулевые коэффициенты. Корень - любое число.");
            }
            else if ((C != 0) && (B == 0) && (A == 0))
            {
                Console.Write("Уравнение не имеет решений.");
            }
            else if (((C == 0) && (B == 0) && (A != 0)) || ((C == 0) && (B != 0) && (A == 0)))
            {
                double D = B * B - 4 * A * C;
                Console.Write("Дискриминант равен " + D + ". Корень равен 0.");
            }
            else if ((C == 0) && (B != 0) && (A != 0))
            {
                double D = B * B - 4 * A * C;
                Console.Write("Дискриминант равен " + D + ". Действительные корни: " + -B / A + " и 0.");
            }
            else if ((C != 0) && (B != 0) && (A == 0))
            {
                double D = B * B - 4 * A * C;
                Console.Write("Дискриминант равен " + D + ". Действительный корень: " + -C / B + '.');
            }
            else
            {
                double D = B * B - 4 * A * C;
                if (D < 0)
                {
                    Console.Write("Дискриминант меньше нуля. Действительных корней нет.");
                }
                else if ((D == 0) && (A != 0))
                {
                    double X = (-B / (2 * A));
                    Console.Write("Дискриминант равен нулю. Действительный корень равен " + X.ToString() + '.');
                }
                else if ((D > 0) && (A != 0))
                {
                    double X1 = ((-B - Math.Sqrt(D)) / (2 * A));
                    double X2 = ((-B + Math.Sqrt(D)) / (2 * A));
                    Console.Write("Дискриминант равен " + D + ". Действительные корни: " + X1 + " и " + X2 + '.');
                }
            }
            Console.ReadKey();           
        }
    }
}
