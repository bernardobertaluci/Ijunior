using System;

namespace Task02
{
    internal class Cell : IReadOnlyCell
    {
        public Cell(Good good, int count = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Good = good ?? throw new NullReferenceException(nameof(good));
            Count = count;
        }

        public Good Good { get; private set; }
        public int Count { get; }

        public Cell Remove(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (count > Count)
                throw new InvalidOperationException("Много запрашиваете!");

            return new Cell(Good, Count - count);
        }

        public Cell Add(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return new Cell(Good, Count + count);
        }
    }
}
