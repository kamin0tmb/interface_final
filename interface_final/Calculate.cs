using System;

namespace interface_final
{
    internal class Summ : ISumm
    {
        ILog log { get; }
        public Summ(ILog log)
        {
            this.log = log;
        }
        public void Summa(int a, int b)
        {
            log.Event("Подсчет суммы произведен");
            Console.WriteLine("Сумма чисел равна: {0}", a + b);
        }
    }
}
