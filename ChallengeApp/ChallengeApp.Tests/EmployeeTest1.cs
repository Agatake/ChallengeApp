namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmloyeeCollectScores_ShouldReturnCorrectResult1()
        {
            //act
            var employee = new Employee("Janek", "Nowak", 20);
            employee.AddScore(1);
            employee.AddScore(2);
            employee.AddScore(3);
            //arrange
            var result = employee.Result; 
            //assert
            Assert.AreEqual(6, result);
        }
        [Test]
        public void WhenEmloyeeCollectScores_ShouldReturnCorrectResult2()
        {
            //act
            var employee = new Employee("Zuzia", "Kowalska", 21);
            employee.AddScore(-4);
            employee.AddScore(5);
            employee.AddScore(6);
            //arrange
            var result = employee.Result;
            //assert
            Assert.AreEqual(7, result);
        }
        [Test]
        public void WhenEmloyeeCollectScores_ShouldReturnCorrectResult3()
        {
            //act
            var employee = new Employee("Ala", "Malinowska", 22);
            employee.AddScore(7);
            employee.AddScore(8);
            employee.AddScore(-9);
            //arrange
            var result = employee.Result;
            //assert
            Assert.AreEqual(6, result);
        }
    }
}