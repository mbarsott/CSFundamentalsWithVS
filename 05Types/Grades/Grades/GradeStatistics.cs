namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;
    }
}