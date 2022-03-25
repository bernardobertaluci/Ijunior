namespace Task04
{
    internal class PaymentSystem2 : PaymentSystem
    {
        private const string _currency = "order.system2.ru/pay";
        public PaymentSystem2(IHash hash) : base(hash)
        {
        }

        protected override string GetLinkParameters(Order order)
        {
            var hash = CalculateHash(order);
            return $"hash={hash}";
        }

        protected override string GetHash(Order order)
        {
            return (order.Id + order.Amount).ToString();
        }

        protected override string GetStringSite()
        {
            return _currency;
        }
    }
}