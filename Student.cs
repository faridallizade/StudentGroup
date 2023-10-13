using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Student : Group
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private double _averagePoint;
        public double AveragePoint
        {
            get
            {
                return _averagePoint;
            }
            set
            {
                if (0 <= value && value <= 100)
                {
                    _averagePoint = value;
                }
            }
        }


        public Student(string Name, string Surname, double AveragePoint)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.AveragePoint = AveragePoint;
        }
    }
}