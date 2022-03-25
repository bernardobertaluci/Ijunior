using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal abstract class PaymentSystem : IPaymentSystem
    {
        private readonly IHash _hash;

        protected PaymentSystem(IHash hash)
        {
            _hash = hash;
        }

        public string GetPayingLink(Order order)
        {
            var parameters = GetLinkParameters(order);
            var fullLink = $"{GetStringSite()}?{parameters}";
            return fullLink;
        }

        protected string CalculateHash(Order order)
        {
            return _hash.GetHashString(GetHash(order));
        }

        protected abstract string GetLinkParameters(Order order);

        protected abstract string GetStringSite();

        protected abstract string GetHash(Order order);
    }
}
