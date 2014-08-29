namespace SchoolProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline()
        {
            this.name = null;
            this.numberOfLectures = int.MinValue;
            this.numberOfExercises = int.MinValue;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        public string DisciplineName
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Discipline name must be filled!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of lectures can't be 0 or negative number!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of exercises can't be 0 or negative number!");
                }
                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            string result = "Discipline name: " + this.name + "\n";
            result += "Number of lectures: " + this.numberOfLectures + "\n";
            result += "Number of exercises: " + this.numberOfExercises + "\n";
            return result;
        }
    }
}
