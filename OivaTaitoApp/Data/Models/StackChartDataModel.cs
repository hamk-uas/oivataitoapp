using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Data.Models
{
    public class StackChartDataModel
    {
        public Dictionary<int, float> AveragePerCategory { get; set; }

        public DateTime EvaluatedAt { get; set; }
    }
}