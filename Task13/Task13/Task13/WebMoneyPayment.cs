namespace Task13
{
    internal class WebMoneyPayment : PaymentHandler
    {
        private readonly WebMoney _webMoney = new WebMoney();
        public override IPaymentSystem GetPaymentSystem()
        {
            return _webMoney;
        }

        public override string ShowConnectText()
        {
            return "Вызов API WebMoney...";
        }
    }
}
