
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        
        [Test]
        public void IntTest()
        {
            //act
            int number1 = 1;
            int number2 = 2;
            
            //arrange

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void StringTest()
        {
            //act
            string name1 = "Agata";
            string name2 = "Agata";

            //arrange

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void FloatTest()
        {
            //act
            float number3 = 1.11f;
            float number4 = 2.22f;

            //arrange

            //assert
            Assert.AreNotEqual(number3, number4);
        }
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //act
            var employee1 = GetEmployee("Janek", "Nowak", 20);
            var employee2 = GetEmployee("Tomasz", "Chmura", 40);
            //arrange
           
            //assert
           Assert.AreNotEqual(employee1, employee2);
         }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
