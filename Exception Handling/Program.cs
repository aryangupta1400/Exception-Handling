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
                //io.InputOutput();
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

    class TypesOfException
    {
        public void IndexOutOfRange()
        {
            int[] intArray = new int[5];

            try
            {
                intArray[7] = 6;
            }
            catch (Exception indexOutOfRange)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(indexOutOfRange.Message);
                Console.ReadKey();
            }
        }

        public void ArrayTypeMismatch()
        {
            string[] stringArray = {"1", "2", "3"};
            object[] objectArray = stringArray;

            try
            {
                objectArray[1] = 3;
            }
            catch (Exception arrayTypeMismatch)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(arrayTypeMismatch.Message);
                Console.ReadKey();
            }
        }

        public void NullRefrence()
        {
            string testVariable = null;

            try
            {
                if (testVariable.Length == 4)
                    Console.WriteLine("Length of 'null' is 4.");
            }
            catch(Exception nullRefrenceException)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(nullRefrenceException.Message);
                Console.ReadKey();
            }
            
                 
        }

        public void DivideByZero()
        {
            int dividend = 10;
            int divisor = 0;

            try
            {
                int quotient = dividend / divisor;
                Console.WriteLine("Quotient = " + quotient);
            }
            catch (Exception divideByZero)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(divideByZero.Message);
                Console.ReadKey();
            }
        }

        public void InvalidCast()
        {
            int firstNumber = 10;
            object secondNumber = firstNumber;
            try
            {
                float thirdNumber = (float)secondNumber;
                Console.WriteLine(thirdNumber);
            }
            catch (Exception invalidCastException)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(invalidCastException.Message);
                Console.ReadKey();
            }
        }

        public void OutOfMemory()
        {
            StringBuilder stringBuilder = new StringBuilder(20, 25);
            stringBuilder.Append("Welcome to Advanced ");

            try
            {
                stringBuilder.Insert(20, "AMC, Ahmedabad");
                Console.WriteLine(stringBuilder.ToString());
                Console.ReadKey();
            }
            catch(Exception outOfMemoryExcepion)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(outOfMemoryExcepion.Message);
                Console.ReadKey();
            }
        }

        public void StackOverflow()
        {
            int count = 0;

            try
            {
                while (true)
                {
                    count = count + 10000;
                }
                Console.WriteLine(count);
            }
            catch (Exception stackOverflowException)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(stackOverflowException.Message);
                Console.ReadKey();
            }
        }

        public void InputOutput()
        {
            try
            {
                File.Open("C:\\advanced.txt", FileMode.Open);
            }
            catch (Exception ioException)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(ioException.Message);
                Console.ReadKey();
            }
        }
    }
}
