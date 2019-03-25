using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Class;

namespace Task1
{
    class Program
    {
        #region ReturnInpuFromClassTheUserChose
        static int ChooseClas()
        {
            Console.WriteLine("Choos a class 1 or 2:");
            int inputClass = int.Parse(Console.ReadLine());
            if (inputClass < 1 || inputClass > 2)
            {
                throw new Exception("Class must be 1 or 2");
            }
            Console.Clear();
            return inputClass;
        }
        #endregion

        #region ReturnInputFromChoosenAction
        static int ChooseAction()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1) Print all female students");
            Console.WriteLine("2) Print all male students");
            Console.WriteLine("3) Print all students with a first letter of a name(user should input a letter )");
            Console.WriteLine("4) Print all students with a grade higher than input(user should input a number from 0 to 10");
            Console.WriteLine("5) Print the Average of all students AverageGrade in the class)");
            int action = int.Parse(Console.ReadLine());
            if(action<1 || action>5)
            {
                throw new Exception("Action must be number beween 1 and 5");
            }
            return action;
        }
        #endregion

        #region AllFemaleStudens
        static List<Student> AllFemale(List<Student>list)
        {
            List<Student> resultLis = list.Where(student => student.Gender == EnumGender.Female).ToList();
            //foreach (Student student in resultLis)
            //{
            //    Console.WriteLine(student);
            //}
            return resultLis;
        }
        #endregion

        #region MaleStudens
        static List<Student> AllMale(List<Student> list)
        {
            List<Student> resultLis = list.Where(student => student.Gender == EnumGender.Male).ToList();
            return resultLis;
        }
        #endregion

        #region studentsWithFirstNameSameAsTheInput
        static List<Student> FirstLetter(List<Student> lista)
        {
            Console.WriteLine("Enter a first letter");
            string letter = Console.ReadLine();
            letter=letter.ToLower();
            List<Student> firstLetter = lista.Where(student => student.FirstName.ToLower().StartsWith(letter)).ToList();
            if (firstLetter.Count > 0)
                return firstLetter;
            else
                throw new Exception($"There is no student with first letter {letter.ToUpper()}");
        }
        #endregion

        #region GradeHigherThanInput
        static List<Student> HigherThanInpu(List<Student>list)
        {
            Console.WriteLine("Enter a number");
            double input = double.Parse(Console.ReadLine());
            if(input<0 || input>10)
            {
                throw new Exception($"The input must be between [0,10]");
            }
            List<Student> studentsList = list.Where(student => student.AverageGrade > input).ToList();
            if (studentsList.Count > 0)
                return studentsList;
            else
                throw new Exception($"There is no student with a grade higher than {input}");

        }
        #endregion

        #region printAverageOfAll
        static void Average(List<Student> student)
        {
            List<double> AverageGrade = student.Select(x => x.AverageGrade).ToList();
            int i = 0;
            double sum = 0;
            foreach (double grade in AverageGrade)
            {
                sum += grade;
                i++;
            }
            double result = sum / i;
            Console.WriteLine($"The average is {result} ");
        }
        #endregion

        #region print FullName
        static void FullName(List<Student> studentList)
        {
            foreach (Student student in studentList
)
            {
                student.PrintInfo();
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Student student1 = new Student("Kristijan", "Spirov", EnumGender.Male, 9.5);
            Student student2 = new Student("Bojan", "Ilev", EnumGender.Male, 6.2);
            Student student3 = new Student("Ivana", "Nakeva", EnumGender.Female, 8.5);
            Student student4 = new Student("Antonio", "Delev", EnumGender.Male, 2.9);
            Student student5 = new Student("Biljana", "Arsova", EnumGender.Female, 7.2);
            Student student6 = new Student("Angelina", "Gerovska", EnumGender.Female, 4.7);
            Student student7 = new Student("Silvija", "Bashovska", EnumGender.Female, 7.0);
            Student student8 = new Student("Adrijan", "Gigov", EnumGender.Male, 9.0);
            Student student9 = new Student("Simona", "Aneva", EnumGender.Female, 10.0);
            Student student10 = new Student("Ilina", "Spirkovska", EnumGender.Female, 5.6);

           List<Student> class1 = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };

            Student student11 = new Student("Gorjan", "Kirov", EnumGender.Male, 8.0);
            Student student12 = new Student("Vasko", "Pecov", EnumGender.Male, 7.6);
            Student student13 = new Student("Ivona", "Zdravevska", EnumGender.Female, 9.0);
            Student student14 = new Student("Lara", "Ivevska", EnumGender.Female, 5.9);
            Student student15 = new Student("Boris", "Savevski", EnumGender.Male, 7.0);
            Student student16 = new Student("Slavko", "Topuzov", EnumGender.Male, 3.5);
            Student student17 = new Student("Tijana", "Ickovska", EnumGender.Female, 4.6);
            Student student18 = new Student("Gorjan", "Petrevski", EnumGender.Male, 8.4);
            Student student19 = new Student("Vedran", "Mackov", EnumGender.Male, 9.8);
            Student student20 = new Student("Mirka", "Andreevska", EnumGender.Female, 6.0);

            List<Student> class2 = new List<Student>() { student11, student12, student13, student14, student15, student16, student17, student18, student19, student20 };
            
            try
            {
                int classNum = ChooseClas();
                int actionNum = ChooseAction();

                switch (actionNum)
                {
                    // if user select to print all female students
                    case 1:
                        //if user pick class 1
                        if (classNum == 1)
                        {
                            List<Student> newList = AllFemale(class1);
                            FullName(newList);
                        }
                        //if user pick class 2
                        else
                        {
                            List<Student> newList = AllFemale(class2);
                            FullName(newList);
                        }
                        break;
                    //if user select to print all male students
                    case 2:
                        if (classNum == 1)
                        {
                            List<Student> newList = AllMale(class1);
                            FullName(newList);
                        }
                        else
                        {
                            List<Student> newList = AllMale(class2);
                            FullName(newList);
                        }
                        break;
                    // if user select to print all students with a first letter from input
                    case 3:
                        if (classNum == 1)
                        {
                            List<Student> newList = FirstLetter(class1);
                            FullName(newList);
                        }
                        else
                        {
                            List<Student> newList = FirstLetter(class2);
                            FullName(newList);
                        }
                        break;
                    //If user select to print all students with a grade higher than input
                    case 4:
                        if (classNum == 1)
                        {
                            List<Student> newList = HigherThanInpu(class1);
                            FullName(newList);
                        }
                        else
                        {
                            List<Student> newList = HigherThanInpu(class2);
                            FullName(newList);

                        }
                        break;
                    //if user select to print the average of all students grades
                    case 5:
                        if (classNum == 1)
                        {
                            Average(class1);
                        }
                        else
                        {
                            Average(class2);
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.ReadLine();
        }
    }
}
