using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Classes.DriverClass
{
    class Driver

    {
        //Properties
        public string Name { get; set; }
        public int Skill { get; set; }

        //Constructor

        public Driver(string name,int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
}
