using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(id: 1111, amount: 12000);

            PaymentSystem paymentSystem1 = new PaymentSystem1(new MD5Hash());
            Console.WriteLine(paymentSystem1.GetPayingLink(order));

            PaymentSystem paymentSystem2 = new PaymentSystem2(new MD5Hash());
            Console.WriteLine(paymentSystem2.GetPayingLink(order));

            string secretKey = "1231233542341";
            PaymentSystem paymentSystem3 = new PaymentSystem3(secretKey, new SHA1Hash());
            Console.WriteLine(paymentSystem3.GetPayingLink(order));
        }
    }
}
