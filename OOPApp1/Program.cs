using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPApp1
{
    internal class Program
    {

        //class Person
        //{
        //    public string Name;
        //}
        //struct Person
        //{
        //    public string Name;
        //}

        static void Main(string[] args)
        {

            #region Part01
            #region Question01
            ////class → reference type → stored in heap → reference copy → supports inheritance
            ////struct → value type → stored on stack → value copy → no inheritance
            //Person p1 = new Person();
            //p1.Name = "Ahmed";

            //Person p2 = p1;   
            //p2.Name = "Mohamed";

            ////// if class
            ////Console.WriteLine(p1.Name); // Mohamed
            ////Console.WriteLine(p2.Name); // Mohamed

            //// if struct
            //Console.WriteLine(p1.Name); // Ahmed
            //Console.WriteLine(p2.Name); // Mohamed 
            #endregion

            #region Question02
            //// public 
            //Student s = new Student();
            //s.Name = "Ahmed";
            //Console.WriteLine(s.Name);

            ////privte 
            //Student s = new Student();
            //s.SetName("Ahmed");
            //Console.WriteLine(s.GetName()); 
            #endregion

            #region Question03
            //Creating a Class Library project
            //Writing public classes and methods
            //Building the project to generate a DLL
            //Adding a project reference to another application
            //Using the library classes inside that application 
            #endregion

            #region Question04
            // A class library helps developers write code once and use it in many applications
            // We Use Class Libraries To :
            // reuse code in multiple projects without rewriting it
            // organize large applications into smaller
            // improve maintainability and make updates easier
            // reduce duplication and increase efficiency 
            #endregion
            #endregion

            #region Part02
            //Console.Write("Enter Movie Name: ");
            //string movie = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            //TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row (A, B, C...): ");
            //char row = char.Parse(Console.ReadLine().ToUpper());

            //Console.Write("Enter Seat Number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price: ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discount = double.Parse(Console.ReadLine());

            //Ticket ticket = new Ticket(movie, type, new Seat(row, number), price);

            //Console.WriteLine();
            //ticket.PrintTicket(14);

            //Console.WriteLine();
            //Console.WriteLine("===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discount:F2}");

            //ticket.ApplyDiscount(ref discount);

            //Console.WriteLine($"Discount After  : {discount:F2}");
            //Console.WriteLine();

            //ticket.PrintTicket(14); 
            #endregion
        }

    }
}
