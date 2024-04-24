namespace ChallengeApp.Tests
{
    public class Employee1Tests
    {
        [Test]
        public void WhenEmployee1CollectGrades_ShouldReturnCorrectMaxScore()
        {
            //act
            var employee1 = new Employee1("Janek", "Nowak");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(6);
            //arrange
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(6, statistics.Max); 
        }
        [Test]
        public void WhenEmployee1CollectGrades_ShouldReturnCorrectMinScore()
        {
            //act
            var employee1 = new Employee1("Janek", "Nowak");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(6);
            //arrange
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void WhenEmployee1CollectGrades_ShouldReturnCorrectAveScore()
        {
            //act
            var employee1 = new Employee1("Janek", "Nowak");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(6);
            //arrange
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(3, statistics.Average);
        }
    }
}
