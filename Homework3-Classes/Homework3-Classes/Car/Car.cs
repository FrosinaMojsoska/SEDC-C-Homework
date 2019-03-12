using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3_Classes.DriverClass;


namespace Homework3_Classes
{
    class Car
    {
        // Properties
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; } 

        // Method
        public int CalculateSpeed(Driver driver)
        {
            int result;
            result = driver.Skill * Speed;
            return result;
        }




        //Constructor

        public Car(string model,int speed)
        {
            Model = model;
            Speed = speed;
        }

    }
}
