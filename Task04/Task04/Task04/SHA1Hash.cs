using System.Security.Cryptography;

namespace Task04
{
    public class SHA1Hash : Hash
    {
        protected override byte[] GetHash(byte[] input)
        {
            using SHA1Managed md5 = new SHA1Managed();
            return md5.ComputeHash(input);
        }
    }
}
