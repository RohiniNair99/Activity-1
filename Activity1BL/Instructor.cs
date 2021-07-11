using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1BL
{
    public class Instructor
    {
        private float avgFeedback;
        private int experience;
        private string instructorName;
        private string[] instructorSkill;

        public Instructor()
        {
            avgFeedback = 0;
            experience = 0;
            instructorName = "";
            instructorSkill=new string[100];
        }

        public Instructor(string instructorName, float avgFeedback, int experience,string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorName = instructorName;
            this.instructorSkill = instructorSkill;
        }

        public bool ValidateEligibility()
        {
            try
            {
                if ((experience > 3 && avgFeedback >= 4.5) || (experience <= 3 && avgFeedback >= 4))
                    return true;
                return false;
            }
            
            catch(ArgumentException)
            {
                Console.WriteLine("Invalid input");
                return false;
            }
        }


        public bool CheckSkill(string technology)
        {
            try
            {
                if (ValidateEligibility())
                {
                    foreach (string skill in instructorSkill)
                    {
                        if (skill.Equals(technology, StringComparison.OrdinalIgnoreCase))
                            return true;

                    }
                }
                return false;
            }

            catch(ArgumentException)
            {
                Console.WriteLine("Invalid Input");
                return false;
            }

            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("End of skill array");
                return false;
            }
        }


    }
}
