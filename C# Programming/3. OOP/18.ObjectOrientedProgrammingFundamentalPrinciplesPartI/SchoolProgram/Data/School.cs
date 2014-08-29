namespace SchoolProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class School : Class
    {
        private List<Class> classes = new List<Class>();
        private School school;
        private string schoolName;

        public School()
        {
            this.schoolName = null;
        }

        public School(string schoolName)
        {
            this.schoolName = schoolName;
        }

        public string SchoolName
        {
            get { return this.schoolName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("School name must be filled!");
                }
                this.schoolName = value;
            }
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Classes must be at least one!");
                }
                this.classes = value;
            }
        }

        public void AddClass(char identifier)
        {
            AddClassRP(identifier);
        }

        private void AddClassRP(char identifier)
        {
            this.Classes.Add(new Class(identifier));
        }

        public void RemoveClass(char identifier)
        {
            RemoveClassRP(identifier);
        }

        private void RemoveClassRP(char identifier)
        {
            for (int i = 0; i < this.Classes.Count; i++)
            {
                if (this.Classes[i].Identifier == identifier)
                {
                    this.Classes.RemoveAt(i);
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in Classes)
            {
                result += "Class identifier: " + item.Identifier + "\n";
            }
            return result;
        }
    }
}
