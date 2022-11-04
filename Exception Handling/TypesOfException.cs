using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class TypesOfException
    {
        // Index out of Range Exception Example
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

        // Array Type Mismatch Exception Example
        public void ArrayTypeMismatch()
        {
            string[] stringArray = { "1", "2", "3" };
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

        // Null Refrence Exception Example
        public void NullRefrence()
        {
            string testVariable = null;

            try
            {
                if (testVariable.Length == 4)
                    Console.WriteLine("Length of 'null' is 4.");
            }
            catch (Exception nullRefrenceException)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(nullRefrenceException.Message);
                Console.ReadKey();
            }
        }

        // Divide by zero Exception Example
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

        // Invalid Cast Exception Example
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

        // Out of Memory Exception Example
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
            catch (Exception outOfMemoryExcepion)
            {
                Console.WriteLine("\n\nAn Exception occured...");
                Console.WriteLine(outOfMemoryExcepion.Message);
                Console.ReadKey();
            }
        }

        // Stackover Flow Exception Example
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

        // I/O Exception Example
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
