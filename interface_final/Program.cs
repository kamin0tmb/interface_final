using System;

namespace interface_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Summ calculate = new Summ();
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число:");
                    var x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    var y = Convert.ToInt32(Console.ReadLine());
                    calculate.Summa(x, y);
                }
                catch (Exception)
                {
                    Console.WriteLine("Должно быть введено число");
                }
            }
        }
    }
    public interface ISumm
    {
        void Summa(int x, int y);
    }

}
