using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public  class People
    {
        private string FullName;
        private DateTime DateOfBrith;
        
       
    
        private string SEX;

        public string FullName1 { get => FullName; set => FullName = value; }
        public DateTime DateOfBrith1 { get => DateOfBrith; set => DateOfBrith = value; }
        
        
      
        public string SEX1 { get => SEX; set => SEX = value; }

        public People() { }

        public People(string fullname, DateTime datebrith, int age, string cccd, string address, string sex)
        {
            this.FullName = fullname;
            this.DateOfBrith = datebrith;
            
            this.SEX = sex;
        }
    }
}
