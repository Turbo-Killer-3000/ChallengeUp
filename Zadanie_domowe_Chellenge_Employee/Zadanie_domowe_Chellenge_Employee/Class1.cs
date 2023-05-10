namespace Chellenge_App
{
    public class Employee
    {
        public List<int> score = new List<int>();

        public Employee(string name, string lastname, string age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string Lastname { get; private set; }

        public string Age { get; private set; }

        public string Score { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void Addscore(int number)
        {
            this.score.Add(number);
        }
    }
}
