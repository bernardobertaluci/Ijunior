using System;

namespace Task02
{
    public class Good
    {
        public Good(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));

            Name = name;
        }

        public string Name { get; }
    }
}