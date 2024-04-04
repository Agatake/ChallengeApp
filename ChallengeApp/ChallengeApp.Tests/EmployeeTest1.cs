namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectResult1()
        {
            //act
            var employee1 = new Employee("Janek", "Nowak", 20);
            employee1.AddScore(-1);
            employee1.AddScore(2);
            employee1.AddScore(3);
            //arrange
            var result = employee1.Result; 
            //assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectResult2()
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
        public void WhenEmployeeCollectScores_ShouldReturnCorrectResult3()
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