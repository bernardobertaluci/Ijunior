using System.Collections.Generic;

class Player{ }
class Gun{ }
class Target{ }
class Unit
{
    public IReadOnlyCollection<Unit> Units { get; private set; }
}
