using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADES
{
    public class Gstats
    {
        public Gstats()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        

                
         

        public string LetterGrade
        {
            get
            {
                string Result;
                if (AverageGrade >= 90)
                {
                    Result = "A";
                }   
                else if (AverageGrade >= 80)
                {   
                    Result = "B";
                }   
                else if (AverageGrade >= 70)
                {   
                    Result = "C";
                }   
                else if (AverageGrade >= 60)
                {   
                    Result = "B";
                }   
                else
                {   
                    Result = "F";
                }
                return Result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
