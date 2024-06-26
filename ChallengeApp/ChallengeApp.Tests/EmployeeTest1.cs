namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployee1CollectScores_ShouldReturnCorrectResult()
        {
            //act
            var employee1 = new Employee("Janek", "Nowak", 20);
            employee1.AddScore(-1);
            employee1.AddScore(-2);
            employee1.AddScore(-3);
            //arrange
            var result = employee1.Result; 
            //assert
            Assert.AreEqual(-6, result);
        }
        [Test]
        public void WhenEmployee2CollectScores_ShouldReturnCorrectResult()
        {
            //act
            var employee2 = new Employee("Zuzia", "Kowalska", 21);
            employee2.AddScore(-4);
            employee2.AddScore(5);
            employee2.AddScore(6);
            //arrange
            var result = employee2.Result;
            //assert
            Assert.AreEqual(7, result);
        }
        [Test]
        public void WhenEmployee3CollectScores_ShouldReturnCorrectResult()
        {
            //act
            var employee3 = new Employee("Ala", "Malinowska", 22);
            employee3.AddScore(7);
            employee3.AddScore(8);
            employee3.AddScore(9);
            //arrange
            var result = employee3.Result;
            //assert
            Assert.AreEqual(24, result);
        }
    }
}