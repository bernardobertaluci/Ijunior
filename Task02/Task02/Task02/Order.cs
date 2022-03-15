namespace Task02
{
    public class Order : IOrder
    {
        private readonly PaylinkBuilder _paylink = new PaylinkBuilder(10);

        public string Paylink => _paylink.Getlink;
    }
}
