using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Student : Person
    {
        private string _studentNumber;

        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }


        public Student(string name, int age, string idNumber, string studentNumber, GenderEnum gender) : base(name, age, idNumber, gender)
        {
            _studentNumber = studentNumber;
        }

        public bool IsElegibleForFutureLab()
        {
            if (_age > 18 && _age < 35)
            {
                return true;
            }
            else return false;
                
        }
    }
}
