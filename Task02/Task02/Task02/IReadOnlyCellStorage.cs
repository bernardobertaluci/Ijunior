using System.Collections.Generic;

namespace Task02
{
    public interface IReadOnlyCellStorage
    {
        IReadOnlyList<IReadOnlyCell> Cells { get; }
    }
}