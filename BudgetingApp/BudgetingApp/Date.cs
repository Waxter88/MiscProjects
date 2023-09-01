using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingApp
{
    internal class Date
    {
        //Object for processing important date values
        
        //Methods for:
        //Printing date information (formatted nicely)
        //Save date value to a file
        //Read date values
        
        public DateTime date { get; set; }
        public string dateName { get; set; }

        public Date(DateTime date, string dateName)
        {
            this.date = date;
            this.dateName = dateName;
        }
        public void PrintDate()
        {
            Console.WriteLine("{0}: {1}", dateName, date);
        }

        public void SaveDate(DateTime date, string fileLocation)
        {
            //Append date to text file at fileLocation
            if (!File.Exists(fileLocation))
            {
                using (StreamWriter sw = File.CreateText(fileLocation))
                {
                    sw.WriteLine(date);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(fileLocation))
                {
                    sw.WriteLine(' ');
                    sw.WriteLine(date);
                }
            }
        }

        //Read ALL date values from fileLocation. Save in an array of DateTime values.
        public static DateTime[] ReadDate(string fileLocation)
        {
            List<DateTime> dateList = new List<DateTime>();
            if (File.Exists(fileLocation))
            {
                using (StreamReader sr = File.OpenText(fileLocation))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s != " ")
                        {
                            dateList.Add(Convert.ToDateTime(s));
                        }
                    }
                }
            }
            return dateList.ToArray();
        }

        //Take an array of DateTime values, format and print them.
        public static void PrintDate(DateTime[] dateArray)
        {
            foreach (DateTime date in dateArray)
            {
                Console.WriteLine(date);
            }
        }




    }
}
