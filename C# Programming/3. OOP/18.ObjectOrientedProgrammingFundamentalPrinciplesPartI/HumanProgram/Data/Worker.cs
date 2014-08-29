namespace HumanProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Worker : Human
    {
        private decimal workHoursPerDay;
        private decimal weekSalary;

        public Worker(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        {
            _firstName = firstName;
            _lastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public override string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("First name must be filled!");
                }
                _firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Last name must be filled!");
                }
                _lastName = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Week salary can't be under $1!");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Work hours per day can't be under 1!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return  (decimal)(this.weekSalary / (this.workHoursPerDay * this.workHoursPerDay));
        }

        public override string ToString()
        {
            return String.Format("Worker first name: {0}\nWorker last name: {1}\nWorker week salary: {2}\nWork hours per day: {3}\nMoney per hour: {4}", _firstName, _lastName, this.weekSalary, this.workHoursPerDay, MoneyPerHour());
        }
    }
}
