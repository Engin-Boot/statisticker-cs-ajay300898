using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats{
        public float average;
        public float max;
        public float min;
        public Stats(float _avg, float _max, float _min){
            average = _avg;
            max = _max;
            min = _min;
        }
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            if(numbers.Count > 0){
                return new Stats(numbers.Average(), numbers.Max(), numbers.Min());
            }
            return new Stats(float.NaN, float.NaN, float.NaN);
        }
    }
}
