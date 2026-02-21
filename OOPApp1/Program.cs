using System;
using static System.Net.Mime.MediaTypeNames;

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

        }

    }
}
