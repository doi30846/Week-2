
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        public string name;
        public string courseID;
        public string lecturer;
        public int maxStudent;
        public int numStudent;


        public Course()
        {
            lecturer = "staff";
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string nm, string cID)
        {
            this.name = nm;
            this.courseID = cID;
            lecturer = "staff";
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string nm, string cID, string lec)
        {
            this.name = nm;
            this.courseID = cID;
            this.lecturer = lec;
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string nm, string cID, string lec, int mStu)
        {
            this.name = nm;
            this.courseID = cID;
            this.lecturer = lec;
            this.maxStudent = mStu;
            numStudent = 0;
        }



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
        public string CourseID
        {
            get
            {
                return courseID;
            }
            set
            {

                if (value.Length > 6)
                {


                    Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                }
                else
                {
                    int x = 0;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsDigit(value[i]))
                            x = 0;
                        else
                            x = 1;
                    }
                    if (x == 0)
                        courseID = value;
                    else
                        Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                }

            }
        }
        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }
        public int NumStudents
        {
            get
            {
                return numStudent;
            }
            set
            {
                if (value > maxStudent)
                {
                    Console.WriteLine(courseID + " error try setting invalid No. Students!");
                }
                else
                {
                    numStudent = value;
                }
            }
        }
        public int MaxStudents
        {
            get
            {
                return maxStudent;
            }
            set
            {
                if (value < numStudent)
                {
                    Console.WriteLine(courseID + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    maxStudent = value;
                }
            }
        }


        public override string ToString()
        {
            return "[Course : " + name + " (" + courseID + "), Lecturer=" + lecturer + ", has " + numStudent + " students, max=" + maxStudent + "]";
        }
    }
}