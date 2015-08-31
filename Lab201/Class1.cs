using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    public class Student
    {
        public string Name, StudentID;
        public bool isActive = true;
        public int YearOfBirth = 1995;
        public int _age;
        public int todayyears = DateTime.Now.Year;
        public string _is;


        public Student()
        {
            Name = "Unknow";
        }
        public Student(string nm)
        {
            Name = nm;
        }

        public Student(string nm, string stid)
        {
            Name = nm;
            StudentID = stid;
        }
        public Student(string nm, string stid, int yrs)
        {
            Name = nm;
            StudentID = stid;
            YearOfBirth = yrs;
        }
        public Student(string nm, string stid, int yrs, bool ac)
        {
            Name = nm;
            StudentID = stid;
            YearOfBirth = yrs;
            isActive = ac;



        }

        public int Age
        {

            get
            {
                return _age;
            }
            set
            {

                _age = todayyears - YearOfBirth;
                _age = value;

            }
        }
        public override string ToString()
        {

            int aage;

            if (Name == "Unknow")
            {
                Name = "John Doe";
                StudentID = "Unknow";
                isActive = false;
            }



            if (isActive == true)
            {
                _is = "is";

            }
            else { _is = "is NOT"; }

            aage = todayyears - YearOfBirth;

            if (aage >= 100 || aage >= 100)
            {

                aage = 22;
            }




            return "[Student : " + Name + "(" + StudentID + ") " + ", Age=" + (aage) + ",  " + _is + " active Student] ";
        }
        //commit

    }
}
