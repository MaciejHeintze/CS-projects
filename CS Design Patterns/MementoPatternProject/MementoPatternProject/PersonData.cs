using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternProject
{
    class PersonData
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

        public void setMemento(Memento memento)
        {
            this.name = memento.Name;
            this.surname = memento.Surname;
            this.phoneNumber = memento.PhoneNumber;

        }

        public Memento CreateMemento()
        {
            return new Memento(name, surname, phoneNumber);
        }
    }
}
