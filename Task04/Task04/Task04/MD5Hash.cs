using System.Security.Cryptography;

namespace Task04
{
    internal class MD5Hash : Hash
    {
        protected override byte[] GetHash(byte[] input)
        {
            using (MD5 md5 = MD5.Create())
                return md5.ComputeHash(input);
        }
    }
}
