using System.Collections.Generic;

namespace MathHammer8
{
    internal class BasicRoll : IRoll
    {
        public IEnumerable<RollResult> Results { get; }

        public BasicRoll()
            : this(6)
        {
            
        }

        public BasicRoll(int sides)
        {
            var resultList = new List<RollResult>(sides);
            for(var sideValue = 1; sideValue <= sides; ++sideValue)
            {
                resultList.Add(new RollResult(sideValue));
            }
            Results = resultList;
        }
    }
}
