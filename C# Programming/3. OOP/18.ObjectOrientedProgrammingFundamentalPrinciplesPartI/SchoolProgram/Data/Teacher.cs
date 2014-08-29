namespace SchoolProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Teacher : Discipline
    {
        private List<Discipline> disciplines = new List<Discipline>();
        private string name;

        public Teacher()
        {
            this.name = null;
        }

        public Teacher(string name)
        {
            this.name = name;
        }

        public string TeacherName
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Teacher name must be filled!");
                }
                this.name = value;
            }
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                if (value.Count == 0)
                {
                    throw new NullReferenceException("Disciplines must have at leat one discipline!");
                }
                this.disciplines = value;
            }
        }

        public void AddDiscipline(string name, int numberOfLectures, int numberOfExercises)
        {
            AddDisciplineRP(name, numberOfLectures, numberOfExercises);
        }

        private void AddDisciplineRP(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Disciplines.Add(new Discipline(name, numberOfLectures, numberOfExercises));
        }

        public void ShowTeacherDisciplines()
        {
            Console.WriteLine(TeacherDisciplines());
        }

        public void RemoveDiscipline(string name)
        {
            RemoveDiscipline(name);
        }

        private void RemoveDisciplineRP(string name)
        {
            for (int i = 0; i < this.Disciplines.Count; i++)
            {
                if (this.Disciplines[i].DisciplineName == name)
                {
                    this.Disciplines.RemoveAt(i);
                }
            }
        }

        private string TeacherDisciplines()
        {
            string result = "";
            foreach (var item in this.Disciplines)
            {
                result += String.Format("Name: {0}\nNumber of lectures: {1}\nNumber of exercises: {2}\n", item.DisciplineName, item.NumberOfLectures, item.NumberOfExercises);
            }
            return result;
        }

        public override string ToString()
        {
            string result = String.Format("Teacher name: ", this.name);
            result += TeacherDisciplines();
            return result;
        }
    }
}
