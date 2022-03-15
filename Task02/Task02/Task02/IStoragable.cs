namespace Task02
{
    public interface IStoragable : IReadOnlyCellStorage
    {
        void Delive(Good good, int count);

        void Extract(Good good, int count);
    }
}
