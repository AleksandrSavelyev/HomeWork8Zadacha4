using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8Zadacha4
{
    class Money
    {
        private int first;
        private int second;
        private int price;
        public Money() { }
        public Money(int first, int second) { }
        public int First
        {
            get { return first; }
            set
            {
                if (value > 0)
                    first = value;
                else
                    first = 0;
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value > 0)
                    second = value;
                else
                    second = 0;
            }
        }
        public int IsMoney
        {
            get
            {
                int totalMoney = first * second;
                return totalMoney;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 1;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"num {first}\t {second}");
        }
        public int GetProd()
        {
            int prod = IsMoney / price;
            return prod;
        }
    }
}
