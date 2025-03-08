using System;
namespace StudentSpace
{
    class Student
    {
        private string name;
        private int rollno;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }
        public int RollNo
        {
            get { return rollno; }
            set
            {
                if (value>0)
                    rollno = value;
            }
        }

    }
}