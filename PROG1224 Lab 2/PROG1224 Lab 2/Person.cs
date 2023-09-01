using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PROG1224_Lab_2
{
    //PROG1224 Assignment 2
    //Date: 02/09/2022
    //By: Jackson Pipe
    public class Person
    {
        readonly public int id;
        readonly public string name;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        public Person(int id, string name)
        {
            name = textInfo.ToTitleCase(name.ToLower());

            this.id = id;
            this.name = name;
        }

        public override string ToString() => "Name: " + name + " ID: " + id;
        public struct Course
        {
            public string code;
            public double grade;

            public Course(string CourseCode, double CourseGrade)
            {
                
                if (CourseCode.StartsWith("PROG", StringComparison.OrdinalIgnoreCase) && CourseCode.Length == 8)
                {
                    this.code = CourseCode;
                }
                else
                {
                    throw new ArgumentException("Course name must begin with PROG followed by 4 digits " + nameof(CourseCode) + " : " + CourseCode);
                }

                if (CourseGrade >= 0 && CourseGrade <= 100)
                {
                    this.grade = CourseGrade;
                }
                else
                {
                    throw new ArgumentException("Course grade must be between 0 and 100 " + nameof(CourseGrade) + " : " + CourseGrade);
                }
            }

        }
        public enum Status
        {
            Unknown, Honours, Passing, Alert, Failing
        }
    }
}
