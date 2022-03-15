using System;
using System.Collections.Generic;

namespace Task02
{
    public class Warehouse : IDisplayable , IStoragable
    {
        private readonly List<Cell> _cells = new List<Cell>();

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public void Extract(Good good, int count)
        {
            int index = FindIndex(good);

            if (index == -1)
                throw new InvalidOperationException(good.Name);

            _cells[index] = _cells[index].Remove(count);
        }

        public void Display()
        {
            foreach (Cell cell in _cells)
            {
                Console.WriteLine(cell.Good.Name + " - " + cell.Count);
            }
        }

        public void Delive(Good good, int count)
        {
            int index = FindIndex(good);

            if (index != -1)
                _cells[index] = _cells[index].Add(count);
            else
                _cells.Add(new Cell(good, count));
        }

        public int FindIndex(Good good)
        {
            return _cells.FindIndex(x => x.Good.Name == good.Name);
        }
    }
}