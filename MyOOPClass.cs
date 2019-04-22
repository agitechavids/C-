using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptualizingOOPPPPPPPPPP
{
    #region A Simple Class
    class Calc
    {
        /// <summary>
        /// Adds two Integers
        /// </summary>
        /// <param name="FirstValue">First Input</param>
        /// <param name="SecondValue">Second Input</param>
        /// <returns>Integer Value....</returns>
        public int Add2Integers(int FirstValue, int SecondValue)
        {
            return FirstValue + SecondValue;
        }
    }

    #endregion

    #region Another Simple Class Declaration & Working
    class myOOPClass
    {
        int firstNumber, secondNumber;

        //Constructor Overloading...
        public myOOPClass()
        {
            Console.Write("Constructor Fired...");
            //firstNumber = 10;
            //secondNumber = 0;
        }

        //P.Constructor...
        public myOOPClass(int firstNo, int secondNo)
        {
            Console.Write("P. Constructor Fired...");
            firstNumber = firstNo;
            secondNumber = secondNo;

        }

        //Method Overloading...
        public int addNumbers()
        {
            return (firstNumber + secondNumber);
        }

        public int addNumbers(int firstNo, int secondNo)
        {
            firstNumber = firstNo;
            secondNumber = secondNo;

            return (firstNumber + secondNumber);
        }

    }
    #endregion

    #region Sealed Class Demo


    /* *******************************Brief************************************
     * Sealed Class: This keyword will not allow the class to be inherited 
     ***************************************************************************/
    sealed class MyClass
    {
        string fName;
        string lName;
        int Age;
        public void GetDetail()
        {
            Console.Write("Enter Your First Name:");
            fName = Console.ReadLine();
            Console.Write("Enter Your Last Name:");
            lName = Console.ReadLine();
            Console.Write("Enter Your Age:");
            Age = int.Parse(Console.ReadLine());

        }

        public void ShowDetail()
        {
            Console.WriteLine(fName + " " + lName + " you are " + Age + " Years Old");
        }
    }

    //class DeriveSealed : MyClass
    //{
    //    //Not Allowed...

    //}

    #endregion

    #region Static Class
    public static class testStaticClass
    {

        public static string returnMsg()
        {
            return "The Static Class method has been called successfully...";
        }

    }
    #endregion

    #region Encapsulation Using Accessors - Mutators
    public class EmployeeDetail
    {
        private string Name;

        // Accessor.
        public string getName()
        {
            return Name;
        }

        // Mutator.
        public void setName(string name)
        {
            Name = name;
        }
    }
    #endregion

    #region Encapsulation Using Properties...
    public class StudentDetail
    {
        private string Name;
        private int _Age;

     

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
    }


    //Auto-Implemented Property....
    public class StudentDetailV2
    {
        public string Name { get; set; }

        public int Age{ get; set; }
    }



    #endregion

    #region Base Class - Derived Class

    public class BaseClass
    {
        public int DataMember;
        public void BaseClassMethod()
        {
            Console.WriteLine("I am a Base Class Method");
        }
    }

    class A
    { 
    
    }
    public class DerivedClass : BaseClass
    {
        public void DerivedClassMethod()
        {
            Console.WriteLine("I am a Derived Class Method");
        }
    }

    #endregion

    #region Abstract Class


    
    public interface ITest {
        void HelloIMessage();
    }
    public abstract class Test {
        public string _CarColor { get; set; }

        public abstract string HelloMessage();
        public string ReturnHelloWorld()
        {
            return "Hello World";
        }
    }


    #endregion

    #region Accessing Interface

    /* **************************************************
     *          Multiple Inheritance.... ****************
     * **************************************************/
    public interface Channel
    {
        //Can't Define Methods
        void Next();
        void Previous();
    }
    public interface Book
    {
        void Next();
        void Chapter();
    }

    //Syntax
    //Class <Class Name> : Interface Comma List
    class AccesInterface : Channel, Book
    {
        //Defining the methods in class
        void Channel.Next()
        {
            Console.WriteLine("Channel Next");
        }
        void Book.Next()
        {
            Console.WriteLine("Book Next");
        }
        public void Previous()
        {
            Console.WriteLine("Previous");
        }
        public void Chapter()
        {
            Console.WriteLine("Chapter");
        }


    }
    #endregion

    #region Inheriting Interface


    interface BaseInterface
    {
        void GetPersonalDetail();
        void GetContactDetail();
    }

    interface DerivedInterface : BaseInterface
    {
        void ShowDetail();
    }

    class InterfaceImplementer : DerivedInterface
    {
        string Name;
        int Age;
        string Address;
        long PhoneNumber;
        public void GetPersonalDetail()
        {
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            Age = int.Parse(Console.ReadLine());

        }
        public void GetContactDetail()
        {

            Console.Write("Enter Your Address:");
            Address = Console.ReadLine();
            Console.Write("Enter Your Phone Number:");
            PhoneNumber = long.Parse(Console.ReadLine());
        }
        public void ShowDetail()
        {

            Random obj = new Random();
            int ID = obj.Next(11, 99);
            Console.WriteLine("");
            Console.WriteLine("Your Details are:");
            Console.WriteLine("Your New ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }

    #endregion

    #region Polymorphism

    #region Operator Overloading
    class MySpecialClass
    {
        private int Number1;
        private int Number2;
        public MySpecialClass()
        {
        }
        public MySpecialClass(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void ShowData()
        {
            Console.WriteLine("The Numbers are: " + Number1 + " and " + Number2);
        }

        // The Block should be
        // 1. public
        //2. static
        //3. Use the operator keyword
        //4. Operator
        public static MySpecialClass operator -(MySpecialClass opr)
        {
            MySpecialClass obj = new MySpecialClass();
            obj.Number1 = -opr.Number1;
            obj.Number2 = -opr.Number2;
            return obj;

        }

        public static MySpecialClass operator +(MySpecialClass opr1, MySpecialClass opr2)
        {
            MySpecialClass obj = new MySpecialClass();
            obj.Number1 = opr1.Number1 + opr2.Number1;
            obj.Number2 = opr1.Number2 + opr2.Number2;
            return obj;
        }

        public static MySpecialClass operator *(MySpecialClass opr1, MySpecialClass opr2)
        {
            MySpecialClass obj = new MySpecialClass();
            obj.Number1 = opr1.Number1 * opr2.Number1;
            obj.Number2 = opr1.Number2 * opr2.Number2;
            return obj;
        }


    }
    #endregion

    #region Function Overloading

    public class Shape
    {
        public void Area(int Side)
        {
            int SquareArea = Side * Side;
            Console.WriteLine("The Area of Square is: " + SquareArea);
        }
        public void Area(int Length, int Bredth)
        {
            int RectangleArea = Length * Bredth;
            Console.WriteLine("The Area of Rectangle is: " + RectangleArea);

        }
        public void Area(double Radius)
        {
            double CircleArea = 3.14 * Radius * Radius;
            Console.WriteLine("The Area of Circle is: " + CircleArea);
        }
        public double Area(double Base, double Height)
        {
            double TriangleArea = (Base * Height) / 2;
            Console.WriteLine("The Area of Triangle is: " + TriangleArea);
            return TriangleArea;
        }
    }
    #endregion

    #region Function Overriding
    public class Person
    {
        int fAge;

        public Person()
        {
            fAge = 21;
        }
        public virtual void setAge(int age)
        {
            fAge = age;
        }
        public virtual int getAge()
        {
            return fAge;
        }
    }

    public class AdultPerson : Person
    {
        public AdultPerson() { }
        public override void setAge(int age)
        {
            if (age > 21)
                base.setAge(age);
            else
                Console.WriteLine("Adult Person's age can not be less than 21...");
        }
    }

    #endregion

    #endregion
}
