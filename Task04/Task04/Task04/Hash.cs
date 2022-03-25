using System.Text;

namespace Task04
{
    public abstract class Hash : IHash
    {
        protected abstract byte[] GetHash(byte[] input);
        public string GetHashString(string s)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(s);
            byte[] hash = GetHash(inputBytes);

            var sb = new StringBuilder();
            foreach (byte b in hash)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
