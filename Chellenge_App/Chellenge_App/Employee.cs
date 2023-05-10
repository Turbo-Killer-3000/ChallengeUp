using System.Diagnostics;

namespace Chellenge_App
{
    public class Employee
    {
        public List<float> grades = new List<float>();

        public Employee(string name, string lastname)
        {
            this.Name = name; 
            this.Lastname = lastname;
        }
        public string Name {get; private set;}

        public string Lastname {get; private set;}

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalide grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))                                                                                                            
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("This string is not float");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            float longAsFloat = (float)grade;
            this.AddGrade(longAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {
             var statistics = new Statistics();
             statistics.Average = 0;
             statistics.Max = float.MinValue;
             statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count) ;
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
            } 

            statistics.Average /= this.grades[index];

            return statistics;
        }
    }
}