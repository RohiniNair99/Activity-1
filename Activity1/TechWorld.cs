using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity1BL;

namespace Activity1
{
    class TechWorld
    {
        static void Main()
        {

            int count = 0;
            Console.WriteLine("\nInstructors in Tech World:");

            // Read file Instructors.txt for instructors 

            var lines = File.ReadAllLines(@"C:\Users\ROHINI NAIR\source\repos\Activity1\Instructors.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                var fields = lines[i].Split(' ');
                Console.Write($"{fields[0]}  ");
            }

            // User input technology interested

            Console.WriteLine("\n\nEnter the technology client interested: ");
            string technology = Console.ReadLine();
        

            // Valid Instructors Check

            Console.WriteLine("\nInstructors that can be allocated: \n");

                // Reading values from file

                for (int i = 0; i < lines.Length; i++)
                {
                    var fields = lines[i].Split(' ');
                          string name = fields[0];
                         float feedback = float.Parse(fields[1]);
                          int exp = Convert.ToInt32(fields[2]);
                          var skill = fields[3].Split(',');

                        // initializing Instructor class object

                          Instructor ins = new Instructor(name, feedback, exp, skill);

                if (ins.CheckSkill(technology))
                {
                    count++;
                    Console.WriteLine($"{count}:{name}");
                    
                }

            }
            if (count == 0)
                Console.WriteLine("No Instructors available");
            Console.ReadLine();
            

        }
    }
}
