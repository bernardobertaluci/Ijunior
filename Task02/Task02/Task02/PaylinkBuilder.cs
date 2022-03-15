using System;

namespace Task02
{ 
    public class PaylinkBuilder
    {
        private readonly Random _random = new Random();
        private readonly int _count;

        public PaylinkBuilder(int count)
        {
            if(count < 1)
                throw new ArgumentException(nameof(count));

            _count = count;     
        }

        public string Getlink => GetPaylink();

        private string GetPaylink()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            char[] arr = new char[_count];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = chars[_random.Next(chars.Length)];
            }

            return new string(arr);
        }
    }
}
