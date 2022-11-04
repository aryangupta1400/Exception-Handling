using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overall try-catch block to handle any unknown exceptions 
            try
            {
                TypesOfException outOfMemory = new TypesOfException();
                //outOfMemory.OutOfMemory();

                TypesOfException nullRefrence = new TypesOfException();
                //nullRefrence.NullRefrence();

                TypesOfException invalidCast = new TypesOfException();
                //invalidCast.InvalidCast();

                TypesOfException arrayTypeMismatch = new TypesOfException();
                //arrayTypeMismatch.ArrayTypeMismatch();

                TypesOfException indexOutOfRange = new TypesOfException();
                //indexOutOfRange.IndexOutOfRange();

                TypesOfException divideByZero = new TypesOfException();
                //divideByZero.DivideByZero();

                TypesOfException stackOverflow = new TypesOfException();
                //stackOverflow.StackOverflow();

                TypesOfException io = new TypesOfException();
                io.InputOutput();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                Console.WriteLine("\n\n These are all the types of Exception you should be aware about.");
            }
        }                
    }    
}
