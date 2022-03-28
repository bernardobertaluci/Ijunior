namespace Task13
{
    internal class Card : IPaymentSystem
    {
        private readonly string _name;

        public Card()
        {
            _name = "Card";
        }

        public string Name => _name;
    }
}
