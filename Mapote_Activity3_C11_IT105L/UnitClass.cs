using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapote_Activity3_C11_IT105L
{
    /* 
    * FullName: Jayvee N. Mapote
    * Section: C11
    * Course: IT105L
    * Laboratory: Activity 3
    */
    internal class UnitClass
    {
        public string[] Username { get { return username; } set { username = value; } }
        private string[] username = new string[2];

        public string[] Birthmonth { get { return birthmonth; } set { birthmonth = value; } }
        private string[] birthmonth = new string[3];

        public string[] Results { get { return results; } set { results = value; } }
        private string[] results = new string[5];

        public string yearlevel(int unit)
        {
            string CurrentyearLevel = string.Empty;

            if (unit > 200 && unit <= 250)
            {
                CurrentyearLevel = "First Year";
            }
            else if (unit > 150 && unit <= 200)
            {
                CurrentyearLevel = "Second Year";
            }
            else if (unit > 100 && unit <= 150)
            {
                CurrentyearLevel = "Third Year";
            }
            else if (unit > 50 && unit <= 100)
            {
                CurrentyearLevel = "Fourth Year";
            }
            else if (unit <= 50)
            {
                CurrentyearLevel = "Fifth Year";
            }
            return CurrentyearLevel;
        }

        public UnitClass(string[] name, string[] mon, int age, int[] Units) 
        {
            username = name;
            results[0] = ($"{username[0]} {username[1]} {username[2]}");
            results[1] = ($"{username[0]} {username[2]}");

            birthmonth = mon;
            results[2] = ($"{birthmonth[0]} {birthmonth[1]} {birthmonth[2]}");

            results[3] = ($"{age}");
            results[4] = ($"{yearlevel(Units[1])}");

        }
    }
}
