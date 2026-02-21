using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp1
{
    public class Student
    {
        private string Name;   

        public void SetName(string name)
        {
            Name = name;   
        }

        public string GetName()
        {
            return Name;
        }
    }
}
