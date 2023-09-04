using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato2
{
    internal class Student
    {
        public string name;
        public string subject;
        public double gpa;

        public Student(string aName, string aSubject, double aGPA)
        {
            name = aName;
            subject = aSubject;
            gpa = aGPA;
        }

        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
