
namespace ChallengeApp
{
    public class Employee1
    {
        private List<float> grades = new List<float>();
        public Employee1(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade) 
        {
            //3
            //3.33
            int valueInInt = (int)grade;
            float f = (float)valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                //Console.WriteLine("invalid data");
            }
        }
        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(long grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else 
            {
                //Console.WriteLine("String is not a float");
            }
        }
        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } 

            statistics.Average /= this.grades.Count;
          
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades) 
            {
               statistics1.Max = Math.Max(statistics1.Max, grade);
               statistics1.Min = Math.Min(statistics1.Min, grade);
               statistics1.Average += grade;    
            }
            statistics1.Average /= this.grades.Count;
            return statistics1;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            var index = 0;
 
            for (var index1 = 0; index1 < this.grades.Count; index1++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index1]);
                    statistics2.Min = Math.Min(statistics2.Min, this.grades[index1]);
                statistics2.Average += this.grades[index1];
            }
            statistics2.Average /= this.grades.Count;
            return statistics2;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;

            var index = 0;
            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Average += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);
            statistics3.Average /= this.grades.Count;
            return statistics3;
        }
    }
            

        }
    

