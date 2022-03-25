namespace Task04
{
    internal class PaymentSystem3 : PaymentSystem
    {
        private readonly string _secretKey;
        private const string _currency = "system3.com/pay";

        public PaymentSystem3(string secretKey, IHash hash) : base(hash)
        {
            _secretKey = secretKey;
        }

        protected override string GetLinkParameters(Order order)
        {
            var hash = CalculateHash(order);
            return $"amount={order.Amount}&currency=RUB&hash={hash}";
        }

        protected override string GetHash(Order order)
        {
            return order.Id.ToString() + order.Amount.ToString() + _secretKey;
        }

        protected override string GetStringSite()
        {
            return _currency;
        }
    }
}