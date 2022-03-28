namespace Task13
{
    public class Qiwi : IPaymentSystem
    {
        private readonly string _name;

        public Qiwi()
        {
            _name = "QIWI";
        }

        public string Name => _name;
    }
}