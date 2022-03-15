using System;

namespace Task02
{
    public class Cart : IDisplayable
    {
        private readonly Warehouse _warehouse;
        private readonly IStoragable _cellStorage = new Warehouse();

        public Cart(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new NullReferenceException(nameof(warehouse));

            _warehouse = warehouse;
        }

        public void Display()
        {
            foreach (Cell cell in _cellStorage.Cells)
            {
                Console.WriteLine(cell.Good.Name + " - " + cell.Count);
            }
        }

        public void Add(Good good, int count)
        {
            _warehouse.Extract(good, count);
            _cellStorage.Delive(good, count);
        }

        public IOrder Order() => new Order();
    }
}