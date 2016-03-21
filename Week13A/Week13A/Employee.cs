using System;

namespace Week13A
{
    class Employee : Person
    {
        private int salary;

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        private string profession;

        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }

        public Room Room;

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", salary: {0}, profession: {1}, room: {2}", salary, profession, Room.Number);
        }
    }

    class Room
    {
        private int number;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public Room(int number)
        {
            this.number = number;
        }
    }
}
