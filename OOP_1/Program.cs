
namespace OOP_1;

using System.ComponentModel;
using OOP1;

class Program
{
    public static String getRange(Seas_on s)
    {
        if (s == Seas_on.autumn)
        {
            return "September to November";
        }
        else if(s == Seas_on.spring)
        {
            return "March to May";
        }
        else if (s == Seas_on.winter) {
            return "December to February";
        }
        else
        {
            return "June to August";
        }
    }
    static void Main(String[] args)
    {
        #region Q1 Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
        //Weekday weekday = new Weekday();
        //for (int i = 1; i <= 7; i++) {
        //    weekday = (Weekday)i;
        //    Console.WriteLine(weekday.ToString());
        //}
        #endregion
        #region Q2 Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        //Seas_on s;
        //bool isParsed;
        //do
        //{
        //    Console.Write("Enter a month: ");
        //    isParsed = Enum.TryParse<Seas_on>(Console.ReadLine(), out s);
        //} while (!isParsed);
        //string y = getRange(s);
        //Console.WriteLine($"{s} have range of months from {y}");

        #endregion
        #region Q3 Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum, Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
        //User user1 = new User();
        //Console.Write("Enter an id for the user: ");
        //int x = int.Parse(Console.ReadLine());
        //user1.id= x;
        //int end = 0;
        //do
        //{
        //    Console.Write("Enter 1 to adjust, 0 to end: ");
        //    int num = int.Parse(Console.ReadLine());
        //    end = num;
        //    if (end == 0)
        //    {
        //        end = 1;
        //        break;
        //    }
        //    else
        //    {
        //        Console.Write("Enter 1 to add, 2 to remove , 3 to check: ");
        //        int input= int.Parse(Console.ReadLine());
        //        if (input == 1 || input ==2)
        //        {
        //            Console.WriteLine("Enter which permission to add read:1  write:2  delete:4  execute:8 ");
        //            int inn = int.Parse(Console.ReadLine());
        //            if (inn == 1)
        //                user1.permission = user1.permission ^ Permissions.Read;
        //            else if (inn == 2)
        //                user1.permission = user1.permission ^ Permissions.Write;
        //            else if (inn == 4)
        //                user1.permission = user1.permission ^ Permissions.Delete;
        //            else
        //                user1.permission = user1.permission ^ Permissions.Execute;
        //        }
        //        else 
        //        {
        //            Console.WriteLine("Enter which permission to check read:1  write:2  delete:4  execute:8 ");
        //            int inn = int.Parse(Console.ReadLine());

        //            if (inn == 8)
        //            {
        //                bool hasExecute;
        //                hasExecute = user1.permission.HasFlag(Permissions.Execute);
        //                if (hasExecute)
        //                    Console.WriteLine("The user has Execute permission");
        //                else
        //                    Console.WriteLine("The user doesn't have Execute permission");
        //            }

        //            else if (inn == 4)
        //            {
        //                bool hasDelete;
        //                hasDelete = user1.permission.HasFlag(Permissions.Delete);
        //                if (hasDelete)
        //                    Console.WriteLine("The user has Delete permission");
        //                else
        //                    Console.WriteLine("The user doesn't have Delete permission");
        //            }
        //            else if (inn == 2)
        //            {
        //                bool hasWrite;
        //                hasWrite = user1.permission.HasFlag(Permissions.Write);
        //                if (hasWrite)
        //                    Console.WriteLine("The user has Write permission");
        //                else
        //                    Console.WriteLine("The user doesn't have Write permission");
        //            }
        //            else
        //            {
        //                bool hasRead;
        //                hasRead = user1.permission.HasFlag(Permissions.Read);
        //                if (hasRead)
        //                    Console.WriteLine("The user has Read permission");
        //                else
        //                    Console.WriteLine("The user doesn't have Read permission");
        //            }
        //        }
        //    }
        //} while (end != 0);



        #endregion
        #region Q4 Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //Console.Write("Enter a color of your choice: ");
        //Colors c = new Colors();

        //bool isParsed = Enum.TryParse<Colors>(Console.ReadLine(),out c);
        //if (isParsed)
        //    Console.WriteLine($"This color is primary color");
        //else
        //    Console.WriteLine("This is not primary color");
        #endregion
    }
}
