using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public float average;
        public float max;
        public float min;
        public Stats CalculateStatistics(List<float> numbers)
        {
            var stats = new Stats();
            if (numbers?.Count > 0)
            {
                average = (numbers.Sum() / numbers.Count);
                max = numbers.Max(x => x);
                min = numbers.Min(x => x);

                stats.average = average;
                stats.max = max;
                stats.min = min;
            }
            return stats;
        }
    }
}
