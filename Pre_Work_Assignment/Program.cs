using System;
using System.ComponentModel.DataAnnotations;

namespace Pre_Work_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables and statements

            //1. Within the Main() method in this application, create variables of the correct data type for the information related to a course, using the information presented below

            //Student information
            string student_FirstName = "Priya";
            string student_LastName = "Alugula";

            Console.WriteLine($"Student Full name is {student_FirstName + " " + student_LastName}");

            //Teacher information
            string teacher_FirstName = "Kal";
            string teacher_LastName = "Academy";

            Console.WriteLine($"Teacher Full name is {teacher_FirstName + " " + teacher_LastName}");

            DateTime _dateOfBirth = new DateTime(1991, 05, 01);

            Console.WriteLine($"teacher date of birth is {_dateOfBirth}");

            string addressLine1 = "Northupway";
            string addressLine2 = "Northupway";
            string city = "Northupway";
            string stateOrProvince = "WA";
            int Zip = 98008;
            string country = "USA";

            Console.WriteLine($"address is {addressLine1 + addressLine2}");
            Console.WriteLine($"city: {city} , state {stateOrProvince} zip: {Zip} and country: {country}");

            //UProgram Information
            string programName = "Bachelors";
            string departmentHead = "Joe";
            int degress = 2;

            Console.WriteLine($"{departmentHead} is leading the program {programName}");

            //degree information
            string degreeName = "Comuter Science";
            int creditsRequired = 40;
            Console.WriteLine($"{creditsRequired} credit points required to complete {degreeName}");

            //Course Information
            string courseName = "OOPs";
            int credits = 3;
            int durationInWeeks = 3;
            string teacher = "Jason";
            Console.WriteLine($" {teacher} will be teaching the courase {courseName} which will be completed in {durationInWeeks} and you will aquire {credits} credits");


            #endregion

            #region print chess pattern
            PatternOfChess patternOfChess = new PatternOfChess();
            patternOfChess.PrintChessPattern(8);
            #endregion

            #region Methods to get the details using Variables you have created above
            /*
            Console.WriteLine("Please enter Student Firstname: ");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter Student Lastname: ");
            string last = Console.ReadLine();
            Console.WriteLine("Please enter Student date of birth: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Program.PrintStudentDetails(first, last, birthday);
            */

            Console.WriteLine("Please enter Teacher Firstname: ");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter Teacher Lastname: ");
            string last = Console.ReadLine();
            string FullName = first + last;
            Console.WriteLine("Please enter CourseName: ");
            string course = Console.ReadLine();
            Console.WriteLine("Please enter UProgram: ");
            string uProgram = Console.ReadLine();
            Console.WriteLine("Please enter DegreeName: ");
            string degree = Console.ReadLine();

            Program.PrintStudentDetails(FullName, course, uProgram, degree);
            #endregion

            #region Exceptions

            try
            {
                ValidateStudentBirthday(_dateOfBirth);
            }
            catch(NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            #endregion
            Console.ReadLine();

        }

        //method to ge the student data
        static void PrintStudentDetails(string first, string lastname, DateTime birthday)
        {
            Console.WriteLine($"{first} {lastname} was born on {birthday} ");
        }

        //Create a method to get information for a teacher, a course, a uprogram, and a degree using a similar method as above
        static void PrintStudentDetails(string teacherName, string course, string uProgram, string degree)
        {
            Console.WriteLine($"{teacherName} will be teaching the course {course} of a UProgram {uProgram} for the students enrolled for degree: {degree} ");
        }

        //Create a new method for validating a student's birthday. You won't write any validation code in this method, but you will throw the NotImplementedException in this method

        static void ValidateStudentBirthday(DateTime birthday)
        {
            //no implementation, testing for NotImplementedException 

            throw new NotImplementedException();
        }
    }
}
