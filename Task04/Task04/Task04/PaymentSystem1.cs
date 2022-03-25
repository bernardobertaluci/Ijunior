namespace Task04
{
    internal class PaymentSystem1 : PaymentSystem
    {
        private const string _currency = "pay.system1.ru/order";
        public PaymentSystem1(IHash hash) : base(hash)
        {
        }

        protected override string GetHash(Order order)
        {
            return order.Id.ToString();
        }

        protected override string GetLinkParameters(Order order)
        {
            var hash = CalculateHash(order);
            return $"amount={order.Amount}RUB&hash={hash}";
        }

        protected override string GetStringSite()
        {
            return _currency;
        }
    }
}