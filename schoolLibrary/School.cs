using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolLibrary
{
   public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string schoolPhoneNumber { get; set; }

        private string _twitter;
        public string Twitter
        {
            //make sure the twitter address starts with @
            get { return _twitter; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitter = value;
                }
                else
                {
                    throw new Exception("the twitter address must begin with @");
                }
            }
        }
        public School()
        {
            Name = "Untitled School";
            schoolPhoneNumber = "555-1234";
        }

        public School(string schoolName, string SchoolPhoneNumber)
        {
            Name = schoolName;
            schoolPhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        public static int AverageThreeScores(int a, int b, int c)
        {
            
            var result = (a + b + c) / 3;
            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.Append(this.City);
            sb.Append(", ");
            sb.Append(this.State);
            sb.Append(" ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
