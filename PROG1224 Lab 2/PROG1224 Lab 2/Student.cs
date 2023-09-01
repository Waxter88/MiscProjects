using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1224_Lab_2
{
    //PROG1224 Assignment 2
    //Date: 02/09/2022
    //By: Jackson Pipe
    public class Student : Person
    {
        public Course[] courses = new Course[6];
        public Status status;

        readonly Status StudentStatus = Status.Unknown;
        Course course
        {
            get { return this.course; }
        }
 
        public Student(Status status, int id, string name) : base(id, name)
        {
            StudentStatus = this.status;
        }

        public string GetHighestMark
        {
            get
            {
                double max = 0;
                string result = "";
                for (int i = 0; i < courses.Length; i++)
                {
                    if(courses[i].grade == max)
                    {
                        result += "Grade: " + courses[i].grade + " Code: " + courses[i].code + " ";
                    }
                    else if(courses[i].grade > max)
                    {
                        max = courses[i].grade;
                        result = "Grade: " + courses[i].grade + " Code: " + courses[i].code;
                    }
                }
                return result;
            }
        }

        public double GetAverage
        {
            get
            {
                double totalGrade = 0;
                double avg;
                for(int i = 0; i < courses.Length; i++)
                {
                    totalGrade += courses[i].grade;
                }
                avg = totalGrade / courses.Length;
                return Math.Round(avg, 2);
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Status: " + status;
        } 
        
        public Status UpdateStatus()
        {
            int coursesFailing = 0; //number of courses below 50%
            for(int i = 0; i < courses.Length; i++)
            {
                if(courses[i].grade < 50)
                {
                    coursesFailing++;
                }
            }
            if(coursesFailing >= 2)
            {
                this.status = Status.Failing;
            }
            else if(coursesFailing == 1 || GetAverage < 60)
            {
                this.status = Status.Alert;
            }
            else if(coursesFailing == 0 && GetAverage >= 80)
            {
                this.status = Status.Honours;
            }
            else
            {
                this.status = Status.Passing;
            }
            return this.status;
        }
    }
}
