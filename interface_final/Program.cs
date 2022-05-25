using System;

namespace interface_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            Summ calculate = new Summ(log);
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    var x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    var y = Convert.ToInt32(Console.ReadLine());
                    calculate.Summa(x, y);
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
        }
    }
    public interface ISumm
    {
        void Summa(int x, int y);
    }
    public interface ILog
    {
        void Event(string mess);
        void Error(string mess);
    }
    public class Log : ILog
    {
        public void Error(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mess);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Event(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Произошла ошибка: {0}", mess);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
