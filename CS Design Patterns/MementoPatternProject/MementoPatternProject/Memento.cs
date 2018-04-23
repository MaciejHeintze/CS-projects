using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternProject
{
    class Memento
    {
        private string name;
        private string surname;
        private int phoneNumber;

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

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public Memento(string name, string surname, int phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
    }
}
