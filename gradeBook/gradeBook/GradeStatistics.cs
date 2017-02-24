using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades 
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue; // largest possible number of a float
        }
        public float AverageGrade;
        public float LowestGrade;
        public float HighestGrade;
    }
}
