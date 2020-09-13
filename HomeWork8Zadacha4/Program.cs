using System;

namespace HomeWork8Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money user = new Money();
            Console.Write("количество купюр:\t");
            user.First = CheVal();
            Console.Write("наминал купюр:\t");
            user.Second = CheVal();
            Console.Write("стоимость товара:\t");
            user.Price = CheVal();
            user.GetInfo();
            Console.WriteLine($"{user.First} купюр наминалом {user.Second}Ррублей составляет {user.IsMoney}Рублей");
            Console.WriteLine($"на {user.Price}рублей можно купить {user.GetProd()}");
        }
        static int CheVal()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int a))
                    return a;
                else
                    Console.Write("неверные данные повторите ввод");
            }
        }

    }
}
