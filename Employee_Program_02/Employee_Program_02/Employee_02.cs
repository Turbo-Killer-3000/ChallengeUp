using Employee_Program_02;

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
        public string Name { get; private set; }

        public string Lastname { get; private set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
            }


            statistics.Average = statistics.Average / this.grades.Count;


            return statistics;      
        }

       
    }
}