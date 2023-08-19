using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    internal interface IEmoployee:IHuman
    {
        
        double Salary { get; set; }
       
        double GetSalary(double bas_sal,double deduction,double bouns);
        void Display();
        void Absense();
        void Attendance();
    }
}
