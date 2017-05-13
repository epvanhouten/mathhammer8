using System.Collections.Generic;

namespace mathhammer8lib
{
    internal class BasicRoll
    {
        public IReadOnlyCollection<RollResult> Results { get; }

        public BasicRoll()
            : this(6)
        {
            
        }

        public BasicRoll(int sides)
        {
            var resultList = new List<RollResult>(sides);
            for(var sideValue = 1; sideValue <= sides; ++sideValue)
            {
                resultList.Add(new RollResult());
            }
            Results = resultList;
        }
    }
}
