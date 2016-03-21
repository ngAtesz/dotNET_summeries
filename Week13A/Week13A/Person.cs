using System;

namespace Week13A
{
    class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public Person()
        {

        }

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public enum Genders : int { Male, Female };

        public Genders gender;

        public override string ToString()
        {
            return String.Format("name: {0}, birthdate: {1}", this.name, this.birthDate);
        }
    }
}
