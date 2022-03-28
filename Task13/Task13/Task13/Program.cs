using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderForm = new OrderForm();

            orderForm.ShowForm();
            var systemId = orderForm.RequestPaymentSystem();

            PaymentHandler paymentHandler = GetPaymentHandler(systemId);
            IPaymentSystem paymentSystem = paymentHandler.GetPaymentSystem();
            Console.WriteLine(paymentHandler.ShowConnectText()); 
            paymentHandler.ShowPaymentText(paymentSystem);
        }

        private static PaymentHandler GetPaymentHandler(string systemId) => systemId switch
        {
            "QIWI" => new QiwiPayment(),
            "WebMoney" => new WebMoneyPayment(),
            "Card" => new CardPayment(),
            _ => throw new NotImplementedException()
        };
        
    }
}