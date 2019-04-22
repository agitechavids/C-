using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FirstTestApp
{
    class Program
    {
        static void Main(string[] args)
        {


            //Open Intellisense(Menu) ==> Shortcut ==> Ctrl +Space
            #region Testing Comment Line...
            //Single Line Comment - Use this....

            /***********************************************************
             * Multi - Line Comment......
             
             ***********************************************************/

            //Third type of Comment .... Discuss Later 
            //Code Documentation
            #endregion

            #region Basic Hello World App - sdjfhlshjdf
            //Console.WriteLine("\n\n\tHello World....");
            #endregion

            #region Debug a program
            //Set a break point
            //Press F11 to continue...
            #endregion

            #region Variable Declaration and Working....
            ////Variable Naming Convention
            ////1. Pascal Case; Both the word's first letter in capital case; like FirstNumber
            ////2. Camel Case: First Word's first letter in small and the second one's in capital case; Like firstNumber

            //int FirstNumber, SecondNumber, AdditionResult;


            //Console.Write("\n\n\tEnter First Value:- ");
            //FirstNumber = int.Parse(Console.ReadLine());


            //Console.Write("\n\n\tEnter Second Value:- ");
            //SecondNumber = Convert.ToInt32(Console.ReadLine());

            ////Any Expression ==> BEDMAS A applies here ==> Bracket Exponentiation(Power) Division Multiplication Addition Subtraction Assignment
            //AdditionResult = FirstNumber + SecondNumber;

            //Console.Write("\n\n\tAddition Result:-" + AdditionResult.ToString());

            #endregion

            #region Implicit and Explicit type Conversion - Play with float and Double

            //float pi = 3.14159f;

            //double doubleVar = 5.5655495965;

            ////Implicitly converted...
            //doubleVar = pi;


            ////Explicit Conversion
            //pi = (float)doubleVar;

            #endregion

            #region Branching...

            #region if-elseif-else...

            ////Break Point setting and tracing a program....
            //int firstNumber, secondNumber;

            //Console.WriteLine("Enter First Number: ");
            //firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second Number: ");
            //secondNumber = int.Parse(Console.ReadLine());

            //Binary Operators: +,-,*,/,>,...
            //if (firstNumber >secondNumber )
            //{
            //    //Place Holder within Console.WriteLine()
            //    Console.WriteLine("First Number, i.e., {0} is greater than {1}", firstNumber, secondNumber);

            //}
            //else if (secondNumber > firstNumber)
            //{
            //    Console.WriteLine("Second Number, i.e., {1} is greater than {0}", firstNumber, secondNumber);
            //}

            //else
            //{
            //    Console.WriteLine("First Number, i.e., {0} is equal to {1}", firstNumber, secondNumber);
            //}


            #region Ternary Operator...
            //int a, b, c;

            //a = 15;
            //b = 10;

            ////////////////Ternary Operator <expr ? op : op> is also supported in C#
            //c = (a > b) ? a : b;

            //Console.WriteLine("Highest Number:-" + c); 
            #endregion



            #endregion

            #region Switch Case Statement in C#.....


            //int number;

            //Console.WriteLine("Input a number between 1 - 4: ");
            //number = int.Parse(Console.ReadLine());


            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Pressed 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Pressed 2");

            //        break;
            //    case 3:
            //        Console.WriteLine("Pressed 3");

            //        break;
            //    case 4:
            //        Console.WriteLine("Pressed 4");

            //        break;
            //    default:
            //        Console.WriteLine("Go to Hell !!!!");

            //        break;

            //}







            #endregion

            #region Group Switch Case in C#

            //string monthName;

            //Console.WriteLine("Input Month Name: ");
            //monthName = Console.ReadLine();


            //switch (monthName)
            //{
            //    case "January":
            //    case "March":
            //    case "May":
            //    case "July":
            //    case "August":
            //    case "October":
            //    case "December":
            //        Console.WriteLine(monthName + " has 31 days");

            //        break;
            //    case "April":
            //    case "June":
            //    case "September":
            //    case "November":
            //        Console.WriteLine(monthName + " has 30 days");

            //        break;
            //    case "February":
            //        Console.WriteLine(monthName + " has 28 days");

            //        break;
            //    default:
            //        Console.WriteLine("Check Spelling of the month");

            //        break;

            //}


            #endregion

            #endregion

            #region Looping in C#
            #region While Loop Demo...

            //// While Loop`
            //int loopControlVariable;

            ////First Step --> Initialization Step
            //loopControlVariable = 1;


            //while (loopControlVariable < 10) //Second Part --> Condition Checking...
            //{
            //    Console.WriteLine("\nI am Executing for loopControlVariable= " + loopControlVariable);

            //    //Third Part....Increment/Decrement
            //    //Unary Operator
            //    loopControlVariable++;


            //}

            //Console.WriteLine("\nI am Executing for loopControlVariable= " + loopControlVariable);



            #endregion

            #region do-while loop demo

            //int loopControlVariable;

            ////First Step --> Initialization
            //loopControlVariable = 15;

            //do
            //{
            //    Console.WriteLine("\nI am Executing for loopControlVariable= " + loopControlVariable);

            //    //Second Part.... Increment/Decrement Loop Controller
            //    loopControlVariable++;

            //} while (loopControlVariable < 10);//Third Part --> Condition Checking...

            #endregion

            #region for Loop Demo


            ////Nested For loops are also supported in C#
            //int loopControlVariable;


            ////All the three steps in one shot...
            //for (loopControlVariable = 0; loopControlVariable < 10; loopControlVariable++)
            //{
            //    Console.WriteLine("\nI am Executing for loopControlVariable= " + loopControlVariable);
            //}


            #endregion

            #region foreach Loop
            //int[] anArray = { 11, 22, 33, 44, 55, 66, 77, 88 };

            //foreach (int values in anArray)
            //    Console.WriteLine(values);
            #endregion
            #endregion

            #region Array...

            #region 1 D Array
            //////////Equivalent C Snippet ==> int arrNo[10];

            ////Declaration...
            //int[] arrNo = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("\nEnter Value for arr[{0}]: ", i);

            //    //How to store
            //    arrNo[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    //How to Retrieve ....
            //    Console.WriteLine("\nValue @arr[{0}]: {1} ", i, arrNo[i]);


            //}

            #endregion

            #region Multi-Dimensional Array
            ////Declaration Method

            ////To connect n number of towers, you need n-1 number of connectors
            //int[,] arrTwoD = new int[3, 3];

            ////Storing Methodology
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("\nEnter Value for arrTwoD[{0},{1}]: ", i, j);
            //        //Store the values
            //        arrTwoD[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Retrieval Methodology...
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("\t" + arrTwoD[i, j]);

            //    }
            //    Console.WriteLine("\n");

            //}

            //Console.WriteLine("\n\tTranspose is");
            //Console.WriteLine("\n\t***************");
            ////Transpose....
            //for (int j = 0; j < 3; j++)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write("\t" + arrTwoD[i, j]);

            //    }
            //    Console.WriteLine("\n");

            //}
            //Console.ReadLine();


            #endregion

            #region Jagged Array
            //Home Task
            #endregion
            #endregion

            #region Playing with Methods...


            #region Calling Void Methods
            ShowMessage();

            //Add2Numerics(); 
            #endregion

            #region Method which returns value and accepts params
            Console.Write("\n\n\tEnter First Value:- ");
            int FirstNumber = int.Parse(Console.ReadLine());

            Console.Write("\n\n\tEnter Second Value:- ");
            int SecondNumber = int.Parse(Console.ReadLine());

            //Use of Placeholders
            Console.Write("\n\n\tAddition of {0} and {1} is {2} ", FirstNumber, SecondNumber, Add2Numbers(FirstNumber, SecondNumber));

            #endregion

            #endregion
            Console.WriteLine("\n\n\tPRESS ENTER TO EXIT...");
            Console.ReadLine();
        }

        public static void ShowMessage()
        {
            Console.Write("\n\n\tI am within ShowMessage Method...");
        }

        public static void Add2Numerics()
        {
            Console.Write("\n\n\tEnter First Value:- ");
            int FirstNumber = int.Parse(Console.ReadLine());

            Console.Write("\n\n\tEnter Second Value:- ");
            int SecondNumber = int.Parse(Console.ReadLine());

            //Use of Placeholders
            Console.Write("\n\n\tAddition of {0} and {1} is {2} ",FirstNumber,SecondNumber,(FirstNumber+SecondNumber));
          
        }


        //Code Documentation
        /// <summary>
        /// This method returns addition of two integers
        /// </summary>
        /// <param name="firstNumber">First Integer Value</param>
        /// <param name="secondNumber">Second Integer Value</param>
        /// <returns>INT 32</returns>      
        public static int Add2Numbers(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber);
        }


    }
}
