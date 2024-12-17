using System.Drawing;
using System.Timers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Console.Write("Please Enter Number:");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sorry Enter A valid Number");
            //}
            #endregion
            #region question 2
            //Console.Write("Please Enter Number:");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number < 0 )
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Postive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sorry Enter A valid Number");
            //}
            #endregion
            #region question 3
            //Console.Write("Enter First Number : ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Third Number : ");
            //int num3 = int.Parse(Console.ReadLine());
            //int max, min;
            //if (num1 >= num2 && num1 >= num3)
            //{
            //    max = num1;
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    max = num2;
            //}
            //else
            //{ 
            //    max=num3;
            //}
            //if (num1 <= num2 && num1 <= num3)
            //{
            //    min = num1;
            //}
            //else if (num2 <= num1 && num2 <= num3)
            //{
            //    min = num2;
            //}
            //else
            //{
            //    min = num3;
            //}
            //Console.WriteLine($"Maximum Number is: {max}");
            //Console.WriteLine($"Minumum Number is: {min}");
            #endregion
            #region question 4
            //Console.Write("Please Enter Number : ");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Even Number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd Number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sorry Enter A valid Number");
            //}
            #endregion
            #region question 5
            //Console.Write("Please Enter A Character : ");
            //char s = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //if (s=='a'||s=='A'||
            //    s == 'e' || s == 'E' ||
            //    s == 'i' || s == 'I' ||
            //     s == 'o' || s == 'O' ||
            //    s == 'u' || s == 'U' )
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion
            #region question 7
            //Console.Write("Please Enter A Number : ");
            //if (int.TryParse(Console.ReadLine(), out int num))
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine(i * num);
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Sorry Enter A valid Number");
            //}
            #endregion
            #region question 9
            //Console.Write("Please Enter Two Number : ");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < num2; i++) 
            //{
            //    result *= num1;
            //}
            //Console.WriteLine($"Output is: {result}");
            #endregion
            #region question 10
            //Console.WriteLine("Enter Marks of Five Subject :");
            //int[] marks = new int[5];
            //int total = 0;
            //double avg, perc;
            //for (int i = 0; i < marks.Length; i++)
            //{ 
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}
            //avg = total / 5.0;
            //perc = (total / 500.0) * 100;
            //Console.WriteLine($"Total is: {total}");
            //Console.WriteLine($"Average is: {avg}");
            //Console.WriteLine($"Perc is: {perc}");

            #endregion
            #region question 11
            //Console.Write("Please Enter Month Number : ");
            //int month=int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Days in Month : 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month : 28");
            //        break;
            //    case 3:
            //        goto case 1;
            //    case 4:
            //        Console.WriteLine("Days in Month : 30");
            //        break;
            //    case 5:
            //        goto case 1;
            //    case 6:
            //        goto case 4;
            //    case 7:
            //        goto case 1;
            //    case 8:
            //        goto case 1;
            //    case 9:
            //        goto case 4;
            //    case 10:
            //        goto case 1;
            //    case 11:
            //        goto case 4;
            //    case 12:
            //        goto case 1;
            //}
            #endregion
            #region  question 17
            //Console.WriteLine("Please Enter Coordinates of Three Points To Check whether they lie on a single straight line. or not");

            //Console.Write("Enter X1 : ");
            //double x1=double.Parse(Console.ReadLine());
            //Console.Write("Enter Y1 : ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter X2 : ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y2 : ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter X3 : ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y1 : ");
            //double y3 = double.Parse(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The Points lie on a straight line");
            //}
            //else
            //    Console.WriteLine("The Points are not lie on a straight line");


            #endregion
            #region question 18
            //Console.Write("Please Enter time take by worker To complete a task(in hours) : ");
            //double TimeByWorker = double.Parse(Console.ReadLine());
            //if (TimeByWorker >= 2 && TimeByWorker <= 3)
            //{
            //    Console.WriteLine("The Worker is highly efficient ");
            //}
            //else if (TimeByWorker > 3 && TimeByWorker <= 4)
            //{
            //    Console.WriteLine("The Worker need to increase their speed ");
            //}
            //else if (TimeByWorker > 4 && TimeByWorker <= 5)
            //{
            //    Console.WriteLine("The Worker need to enhance their speed ");
            //}
            //else
            //    Console.WriteLine("Worker need to leave company!!!");
            #endregion
            #region question21
            //int x = 6;
            //int y = x;
            //Console.WriteLine("First Value of X is " + x);
            //Console.WriteLine("First Value of Y is " + y);
            //Console.WriteLine("=============================");
            //x = 10;
            //Console.WriteLine("Second Value of X is " + x);
            //Console.WriteLine("Second Value of Y is " + y);
            //Console.WriteLine("=============================");
            ////after modification y not affected because it take copy of first value of x not affected by anychange
            #endregion
            #region question22
            //Class1 P1 = new Class1();
            //P1.x = 21;
            //P1.y = 5;
            //Class1 P2 = new Class1();
            //P2 = P1;
            //Console.WriteLine("Before modification:");
            //Console.WriteLine("Point1: " + P1);
            //Console.WriteLine("Point2: " + P2);
            //P1.x = 14;
            //P1.y = 3;
            //Console.WriteLine("After modification:");
            //Console.WriteLine("Point1: " + P1);
            //Console.WriteLine("Point2: " + P2);
            ////when assigned two variable by ref two variable points to same memory location so when modify one of them the other change automatically
            #endregion
            #region question23
            //(b) A value 1 will be assigned to d.
            #endregion
            #region question24
            //(d) 6 1
            #endregion
            #region question25
            //(d) 7 7
            #endregion

        }

    }
}
