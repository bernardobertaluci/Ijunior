namespace Task13
{
    internal class CardPayment : PaymentHandler
    {
        private readonly Card _cardPayment = new Card();
        public override IPaymentSystem GetPaymentSystem()
        {
            return _cardPayment;
        }

        public override string ShowConnectText()
        {
            return "Вызов API банка эмитера карты Card...";
        }
    }
}
