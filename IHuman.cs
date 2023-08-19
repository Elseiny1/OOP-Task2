using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    internal interface IHuman
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }
}
