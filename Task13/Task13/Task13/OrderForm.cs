using System;

namespace Task13
{
    public class OrderForm
    {
        public void ShowForm()
        {
            Console.WriteLine("Мы принимаем: QIWI, WebMoney, Card");
            Console.WriteLine("Какое системой вы хотите совершить оплату?");
        }

        public string RequestPaymentSystem()
        {            
            return Console.ReadLine();
        }
    }
}