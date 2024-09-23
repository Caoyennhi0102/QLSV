using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public  class Student:People
    {
        private string  Student_ID;
        private string Class;
        private double DTB;
      
        
       
       
        public string Class1 { get => Class; set => Class = value; }
        public double DTB1 { get => DTB; set => DTB = value; }
        public string Student_ID1 { get => Student_ID; set => Student_ID = value; }

        public Student()  { }

        public Student(string fullname, DateTime datebrith,  string sex, string  student, string classs, double dtb) : base()
        {
            this.FullName1 = fullname;
            this.DateOfBrith1 = datebrith;
            this.SEX1 = sex;
            this.Student_ID = student;
            this.Class = classs;
            this.DTB = dtb;
            
        }

        
    }
}
