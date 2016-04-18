using System;

namespace Week13A
{
    class Person
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                _birthDate = value;
            }
        }

        public Person()
        {

        }

        public Person(string name, DateTime birthDate)
        {
            this._name = name;
            this._birthDate = birthDate;
        }

        public enum Genders : int { Male, Female };

        public Genders Gender;

        public override string ToString()
        {
            return String.Format("name: {0}, birthdate: {1}", this._name, this._birthDate);
        }
    }
}
