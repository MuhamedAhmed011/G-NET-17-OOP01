using System;

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
            // Part 01

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

        }
    
    }
}
