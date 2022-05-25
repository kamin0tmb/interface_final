using System;

namespace interface_final
{
    internal class Summ : ISumm
    {

        public void Summa(int a, int b)
        {
            Console.WriteLine("Сумма чисел равна: {0}", a + b);
        }
    }
}