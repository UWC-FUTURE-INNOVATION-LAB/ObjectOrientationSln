using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Person
    {
        private string _name;
        protected int _age;
        private string _idNumber;
        private GenderEnum _gender;

     
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        public GenderEnum Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }



        public Person(string name, int age, string idNumber, GenderEnum gender)
        {
            _name = name;
            _age = age;
            _idNumber = idNumber;
            _gender = gender;
        }

    }
}
