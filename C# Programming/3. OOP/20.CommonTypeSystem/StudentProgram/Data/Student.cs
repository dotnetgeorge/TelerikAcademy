namespace StudentProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum SpecialityType { Marketing, Business, Enterpreneurship, Phisics, Mathematics, Telecommunications};
    public enum UniversityType { TU, SU, NBU, UNSS };
    public enum FacultiesType { Mathematics, Law, Business, Philosophy, Phisics, Management, Telecommunications };

    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private SpecialityType speciality;
        private UniversityType university;
        private FacultiesType faculties;

        public Student()
        {
            this.firstName = null;
            this.middleName = null;
            this.lastName = null;
            this.ssn = null;
            this.address = null;
            this.phoneNumber = null;
            this.email = null;
            //this.speciality = Speciality;
            //this.university = University;
            //this.faculties = Faculties;
        }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string phoneNumber, string email, SpecialityType speciality, UniversityType university, FacultiesType faculties)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.speciality = speciality;
            this.university = university;
            this.faculties = faculties;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("First name must be filled!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Middle name must be filled!");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Last name must be filled!");
                }
                this.lastName = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("SSN must be filled!");
                }
                this.ssn = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Address must be filled!");
                }
                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Phone number must be filled!");
                }
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("E-mail must be filled!");
                }
                this.email = value;
            }
        }

        public SpecialityType Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }

        public UniversityType University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public FacultiesType Faculties
        {
            get { return this.faculties; }
            set { this.faculties = value; }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!((Object.Equals(this.firstName, student.FirstName)) && (Object.Equals(this.middleName, student.MiddleName)) && (Object.Equals(this.lastName, student.LastName))))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return (FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode());
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("First name: {0}\nMiddle name: {1}\nLast name: {2}\nSSN: {3}\nAddress: {4}\n" +
                "Phone number: {5}\nE-mail: {6}\nSpeciality: {7}\nUniversity: {8}\nFaculties: {9}",this.firstName, this.middleName, this.lastName, this.ssn, this.address, this.phoneNumber, this.email, this.speciality, this.university, this.faculties);

            return result.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public Student Clone()
        {
            Student original = this;
            Student copy = new Student(original.firstName, original.middleName, original.lastName, original.ssn, original.address, original.phoneNumber, original.email, original.speciality, original.university, original.faculties);
            return copy;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return String.Compare(this.FirstName, student.FirstName);
            }
            if (this.LastName != student.LastName)
            {
                return String.Compare(this.LastName, student.LastName);
            }
            if (this.SSN != student.SSN)
            {
                return String.Compare(this.SSN, student.SSN);
            }

            return 0;
        }
    }
}
