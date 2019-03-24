using System;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }

                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result = "F";
                double RoundAverage = Math.Round(AverageGrade);
                if (RoundAverage >= 90)
                {
                    result = "A";
                }
                else if (RoundAverage >= 80)
                {
                    result = "B";
                }
                else if (RoundAverage >= 70)
                {
                    result = "C";
                }
                else if (RoundAverage >= 60)
                {
                    result = "D";
                }

                return result;
            }
        }

        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;
    }
}