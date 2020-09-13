using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats{
        private float average{ get; set;}
        private float max{ get; set;}
        private float min{ get; set;}
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
