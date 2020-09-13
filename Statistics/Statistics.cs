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
            if(numbers.Count > 0){
                return new Stats(){average = numbers.Average(), max = numbers.Max(), min = numbers.Min() };
            }
            return new Stats(){average = float.NaN, max = float.NaN, min = float.NaN };
        }
    }
}
