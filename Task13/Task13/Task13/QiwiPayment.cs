namespace Task13
{
    public class QiwiPayment : PaymentHandler
    {
        private readonly Qiwi _qiwi = new Qiwi();
        public override IPaymentSystem GetPaymentSystem()
        {
            return _qiwi;
        }

        public override string ShowConnectText()
        {
            return "Перевод на страницу QIWI...";
        }
    }
}