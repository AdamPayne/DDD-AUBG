using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Value_Object
{
    class Conference
    {
        private readonly string _ConferenceName;
        public string ConferenceName
        {
            get { return _ConferenceName; }
        }

        private readonly DateTime _ConferenceDate;
        public DateTime ConferenceDate
        {
            get { return _ConferenceDate;  }
        }

        public Conference(string ConferenceName, DateTime ConferenceDate)
        {
            this._ConferenceName = ConferenceName;
            this._ConferenceDate = ConferenceDate;
        }

        public override bool Equals(object obj)
        {
            if((obj==null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Conference conf = (Conference)obj;
                return (ConferenceName.Equals(conf.ConferenceName)) && (ConferenceDate.Equals(conf.ConferenceDate));
            }
        }

        public override int GetHashCode()
        {
            return ConferenceName.GetHashCode() ^ ConferenceDate.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Conference({0}, {1})", ConferenceName, ConferenceDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string ai = "a";
            string bi = "a";
            Console.WriteLine(ai.Equals(bi));
        }
    }
}
