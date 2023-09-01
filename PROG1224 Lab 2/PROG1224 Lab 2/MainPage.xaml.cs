using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PROG1224_Lab_2
{
    //PROG1224 Assignment 2
    //Date: 02/09/2022
    //By: Jackson Pipe
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            Student student1 = new Student(Person.Status.Unknown, 12345, "Sasha Hostyn");
            Student student2 = new Student(Person.Status.Unknown, 67890, "Cho Seong-Ju");
            Student student3 = new Student(Person.Status.Unknown, 13579, "Greg Fields");

            Person person1 = new Person(12345, "Sasha Hostyn");
            

            Person.Course course6 = new Person.Course("PROG1234", 12);
            Person.Course course5 = new Person.Course("PROG2222", 35);
            Person.Course course4 = new Person.Course("PROG3589", 99);
            Person.Course course3 = new Person.Course("PROG5454", 100);
            Person.Course course2 = new Person.Course("PROG1111", 76);

            Person.Course course1 = new Person.Course();

            //Person ToString() 
            result += "Person ToString(): \n" + student1.ToString() + "\n\n" + student2.ToString() + "\n\n" + student3.ToString() + "\n\n";

            //Person Property Test
            result += "Person Property Test: \n" + "Name: " + person1.name + "\nID: " + person1.id + "\n\n";

            //Course Structure (Default Constructor)
            result += "Course Structure (Default Constructor): \n\n" + "Course Code: " + course1.code + " Course Grade: " + course1.grade + "\n\n";

            //Course Structure (Two Parameter Constructor)
            result += "Course Structure (Two Parameter Constructor): \n\n" + "Course Code: " + course2.code + " Course Grade: " + course2.grade + "\n\n";

            //Populate Course[] Array for student object
            student1.courses = new Person.Course[] { course1, course2, course3, course4, course5, course6 };

            //Student Update Status:
            student1.UpdateStatus();

            //Student ToString():
            result += "Student ToString(): \n\n" + student1.ToString() + "\n\n";

            //Loop through Course[] Array
            string CourseList = "Course List: \n\n";
            for(int i = 0; i < student1.courses.Length; i++)
            {
                CourseList += "Course #" + (i + 1) + ": " + student1.courses[i].code + " " + student1.courses[i].grade + "\n";
            }
            result += CourseList + "\n\n";

            //GetHighestMark and GetAverage
            result += "Get highest mark: " + student1.GetHighestMark + "\n\n";
            result += "Get average: " + student1.GetAverage + "\n\n";
            
            //Output results
            txtResult.Text = result;
        }
    }
}
