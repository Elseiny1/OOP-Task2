using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    internal interface IManager:IEmoployee
    {
        void Hire();
        void Fire();
    }
}
