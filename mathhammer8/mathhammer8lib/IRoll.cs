using System.Collections.Generic;

namespace MathHammer8
{
    interface IRoll
    {
        IEnumerable<RollResult> Results { get; }
    }
}
