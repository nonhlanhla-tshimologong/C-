using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        /*Elementary.Volume volume;
        HighSchool.Volume Volume2;*/

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()
        {
           Name = "Untitled School";
            PhoneNumber = "555-2222";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber; ;
        }
        
        public float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
    }
}
