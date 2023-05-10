namespace Chellenge_App
{
    public class TypeTests
    {
        [Test]
        public void TestWithVarEmployeeAndGetEmployee()
        {
            // arrange
            var emplyee1 = GetEmployee("Mateusz", "Badura");

            // act

            // assert
        }

        private Employee GetEmployee(string name, string lastname)
        {
            return new Employee(name, lastname);
        }
        [Test]
        public void TestWithIntAndString()
        {
            // arrange
            string Name1 = "Marcin";
            string Name2 = "Janek";

            int nuber = 5;
            int nuber2 = 5;
            Assert.AreEqual(nuber, nuber2);

            var Employee = GetEmployee("Stachu", "z");
            var Employee2 = GetEmployee("Json", "Botak");


            // act

            // assert

        }
    }
}