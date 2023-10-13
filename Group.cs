using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Group
    {
        private string _no;
        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (CheckNo(value))
                {
                    _no = value;
                }
            }
        }
        public int StudentLimit { get; set; }
        Student[] Students;

        public Group(string No)
        {
            this.No = No;
        }
        public Group()
        {
            Students = new Student[0];
        }


        public bool CheckNo(string no)
        {
            if (char.IsUpper(no[0]) && char.IsUpper(no[1]) && no.Length == 5)
            {
                for (int i = 2; i <= 5; i++)
                {
                    if (!char.IsDigit(no[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void ShowAllStudent()
        {
            foreach (Student item in Students)
            {
                Console.WriteLine($"{item.Name}  {item.Surname}  : {item.AveragePoint}");
            }
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length] = student;
        }

        public Student[] FilterbyName(string search)
        {
            Student[] filteredStudent = new Student[0];
            for (int i = 0; i < Students.Length; i++)
            {
                if ($"{Students[i].Name}  {Students[i].Surname}".ToLower().Contains(search))
                {
                    Array.Resize(ref filteredStudent, filteredStudent.Length + 1);
                    filteredStudent[filteredStudent.Length - 1] = Students[i];
                }
            }
            return filteredStudent;
        }
    }
}
