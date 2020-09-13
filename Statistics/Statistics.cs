using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats{
        private average{ get; set;}
        private max{ get; set;}
        private min{ get; set;}
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            float _avg = numbers.Count > 0 ? numbers.Average() : float.NaN;
            float _max = numbers.Count > 0 ? numbers.Max(): float.NaN;
            float _min = numbers.Count > 0 ? numbers.Min(): float.NaN;
            return new Stats(){average = _avg, max = _max, min = _min };
        }
    }
}
