namespace Task13
{
    internal class WebMoney : IPaymentSystem
    {
        private readonly string _name;

        public WebMoney()
        {
            _name = "WebMoney";
        }

        public string Name => _name;
    }
}
