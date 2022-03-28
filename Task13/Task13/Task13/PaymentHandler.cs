using System;

namespace Task13
{
    public abstract class PaymentHandler
    {
        public abstract IPaymentSystem GetPaymentSystem();

        public abstract string ShowConnectText();

        public void ShowPaymentText(IPaymentSystem paymentSystem)
        {
            Console.WriteLine($"Вы оплатили с помощью {paymentSystem.Name}");
            Console.WriteLine($"Проверка платежа через {paymentSystem.Name}...");
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}