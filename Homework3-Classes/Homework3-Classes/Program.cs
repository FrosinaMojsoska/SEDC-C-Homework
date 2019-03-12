using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Homework3_Classes.DriverClass;

namespace Homework3_Classes
{




    class Program
    {

        #region methodForCarInput
        static Car InputCar(Car[] cars)
        {

            Car:
            Console.WriteLine("Choose a car:");
            int i=1;
            foreach (Car car in cars)
            {
                Console.WriteLine($"{i}) {car.Model}");
                i++;

            }
            #region carInput
            int carNumber;
            bool checkCar = int.TryParse(Console.ReadLine(), out carNumber);

            if(!checkCar)
            {
                Console.WriteLine("You need to enter a number");
                goto Car;
              
            }
             if((carNumber<1) ||  (carNumber>4))
            {
                Console.WriteLine("Entered number must be 1,2,3 or 4");
                goto Car;
            }
            #endregion

            return cars[carNumber-1];
        }

        #endregion


        #region methodForDriverInput
        static Driver InputDriver(Driver[] drivers)
        {
            Driver:
            Console.WriteLine("Choose a driver:");
            int k = 1;
            foreach (Driver driver in drivers)
            {
                Console.WriteLine($"{k}) {driver.Name}");
                k++;

            }
            #region driverInput
            int driverNumber;
            bool checkDriver = int.TryParse(Console.ReadLine(), out driverNumber);

            if (!checkDriver)
            {
                Console.WriteLine("You need to enter a number");
                goto Driver;

            }
             if ((driverNumber < 1) || (driverNumber > 4))
            {
                Console.WriteLine("Entered number must be 1,2,3 or 4");
                goto Driver;
            }
            #endregion

            return drivers[driverNumber - 1];

        }
        #endregion

        #region RaceCarsMethod
        static void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed(car1.Driver) > car2.CalculateSpeed(car2.Driver))
            {
                Console.WriteLine($"Car model: {car1.Model} with {car1.Driver.Name} driver and speed {car1.Speed} was faster ");
            }
            else if (car1.CalculateSpeed(car1.Driver) < car2.CalculateSpeed(car2.Driver))
            {
                Console.WriteLine($"Car model: {car2.Model} with {car2.Driver.Name} driver and speed {car2.Speed} was faster ");
            }
            else
            {
                Console.WriteLine($"{car1.Model} and {car2.Model} arrived in the same time");
            }
        }

        #endregion
        #region checkIfTheUserWantsToRaceAgain
        static bool YesNo()
        {

     
            Console.WriteLine("Would you like to race again enter (Y for yes and N for no)");
            string answer = Console.ReadLine();

            if (answer == "Y")
            {

                return true;
            }
            else
            {
                
                return false;
                
                    };


          
        }
        #endregion
        static bool RaceAgain(Car[] cars,Driver[] drivers)
        {
            Car first = InputCar(cars);
            first.Driver = InputDriver(drivers);

            #region eleminateFirstChosenOption
            Car[] cars2 = cars;
            Array.Resize(ref cars2, cars2.Length - 1);

            Driver[] drivers2 = drivers;
            Array.Resize(ref drivers2, drivers2.Length - 1);
            int z = 0;
         
            foreach (Car car in cars)
            {
                if(car!=first)
                {
                    cars2[z] = car;
                    z++;
                }
           
            }

            int d = 0;
            foreach (Driver driver in drivers)
            {
                if (driver != first.Driver)
                {
                    drivers2[d] = driver;
                    d++;
                }
            }
            #endregion



            Car second = InputCar(cars2);
            second.Driver = InputDriver(drivers2);

            RaceCars(first, second);
            
            return YesNo();
         
        }
        static void Main(string[] args)
        {
        
        

            Car car1 = new Car("Hyundai", 240);
            Car car2 = new Car("Mazda", 250);
            Car car3 = new Car("Ferrari", 340);
            Car car4 = new Car("Porsche", 300);
            Car[] cars = { car1, car2, car3, car4 };

            Driver driver1 = new Driver ("Bob",4);
            Driver driver2 = new Driver ("Greg", 3 );
            Driver driver3 = new Driver ("Jill", 5 );
            Driver driver4 = new Driver ( "Anne", 4 );

            Driver[] drivers = { driver1, driver2, driver3, driver4 };


            bool result = RaceAgain(cars, drivers);
            
            if(result == true)
            {
                RaceAgain(cars, drivers);
                
            }
      
            Console.ReadLine();

        }
    }
}
