using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConceptualizingOOPPPPPPPPPP;

namespace ConceptualizingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Understanding Basic Class and Object
            //////this is the way to instantiate object of any class
            /////Syntax is:
            /////<Class Name> <Object Name> = new <Class Name>()
            //Calc myObject = new Calc();

            //int fistInput, secondInput, addResult;

            //Console.Write("Input First Value:- ");
            //fistInput = int.Parse(Console.ReadLine());

            //Console.Write("Input Second Value:- ");
            //secondInput = int.Parse(Console.ReadLine());


            //addResult = myObject.Add2Integers(fistInput, secondInput);

            //Console.Write("Addition of {0} and {1} is {2}", fistInput, secondInput, addResult);
            #endregion

            #region Using Class - Object



            //////////////////Variable Names in Pascal Case in Main Function...
            //////////////// And Camel Case in Class File


            //int FirstNumber, SecondNumber, AddResult;

            ////Instantiation of object....
            ////<class Name> <Object Name> = new <Class Name>();
            //myOOPClass MyClassObj = new myOOPClass();

            //Console.WriteLine("\nSupply First Number:- ");

            //FirstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nSupply Second Number:- ");

            //SecondNumber = int.Parse(Console.ReadLine());

            //AddResult = MyClassObj.addNumbers(FirstNumber, SecondNumber);

            //Console.WriteLine("Result = " + AddResult);
            //Console.ReadLine();

            ////Using Parameterized Constructor

            //Console.WriteLine("\nSupply First Number:- ");

            //FirstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nSupply Second Number:- ");

            //SecondNumber = int.Parse(Console.ReadLine());

            ////Instantiation with P. Constructor
            //myOOPClass myClassObj2 = new myOOPClass(FirstNumber, SecondNumber);
            //AddResult = myClassObj2.addNumbers();

            //Console.Write("\nResult = " + AddResult);
            ////Console.ReadLine(); 


            #region Special Notes

            /* *****************************************************************************************************************************
             * **************************Important ==> Access Specifiers.....***************************************************************
             * *****************************************************************************************************************************
             * 1. Private: means only other members of the same class can access that
             * 2. Public: means anyone can access that
             * 3. Protected: means public to subclasses, private to everyone.
             * 4. Internal: means public only to other classes in an assembly.
             *              Explanation: The built-in Dot Net framework classes are assemblies - libraries of classes that are in ur project's 
             *                           list of references.
             *                           U can see see a list of assemblies by right clicking on references in the Solution Explorer and choosing 
             *                           "Update Reference"
             *                           When u build an assembly, U can use internal keyword to keep classes private to that assembly, so you can only 
             *                           only expose the classes you want.
             *                           
             * *********************************************************************************************************************************/
            #endregion


            #endregion

            #region Using Sealed Class...
            //MyClass obj = new MyClass();
            //obj.GetDetail();
            //obj.ShowDetail();


            //Head First Design Pattern -
            //Design Pattern ==> GoF ==> Gang of Four
            //23 Design Patterns



            #endregion

            #region Static Class Demo

            ////Static Class Can't be instantiated......
            ////Means the following line is not allowed...
            ////testStaticClass obj = new testStaticClass();

            //string msg = testStaticClass.returnMsg();
            //Console.Write("\nMessage:- " + msg);

            ////Console.ReadLine();

            #endregion

            #region Number of Digits Calculation
            //double testInput = 45697987;
            //double count = Math.Log10(testInput) + 1;


            ////3 digit ==> 2.0000 
            ////Explicit Casting 
            //int fCount = (int)count;

            //Console.WriteLine(fCount); 
            #endregion

            #region Encapsulation By Accessor & Mutator ...
            //EmployeeDetail detail = new EmployeeDetail();


            //Console.Write("\nInput User Name:- ");
            //detail.setName(Console.ReadLine());


            //Console.WriteLine("The Employee Name is : " + detail.getName());

            ////Console.Write("\nPress ENTER to quit...");
            ////Console.ReadLine();
            #endregion

            #region Encapsulation By Properties ...
            //StudentDetail detail = new StudentDetail();

            //Console.Write("\n\tInput UserName: ");
            //detail.StudentName = Console.ReadLine();

            //Console.Write("\n\tInput User's Age: ");
            //detail.Age =int.Parse(Console.ReadLine());

            //Console.Write("\n{0}, whose age is:{1} ", detail.StudentName,detail.Age);

            //Console.Write("\nPress ENTER to quit...");
            //Console.ReadLine();

            ////Dot Net 3.5 onwards enhancement
            //StudentDetailV2 obj = new StudentDetailV2();
            //obj.Name = "Test Dot NET 3.5";
            //obj.Age = 5;
            //Console.Write("\nDot Net 3.5 Testing:-{0}. Age is {1} " ,obj.Name,obj.Age);



            #endregion

            #region Inheriting a class

            //////Create a Base Class Object
            //Console.WriteLine("I am going to access a Base Class Object:");
            //BaseClass bc = new BaseClass();
            //bc.DataMember = 1;
            //Console.WriteLine("Value at bc = " + bc.DataMember);
            //bc.BaseClassMethod();


            ////////////Create a Derived Class Object
            ////////Console.WriteLine("");
            //////Console.WriteLine("I am now going to access Derived Class Object:");
            //DerivedClass dc = new DerivedClass();
            //dc.DataMember = 2;
            //Console.WriteLine("Value at bc = " + bc.DataMember);
            //Console.WriteLine("Value at dc = " + dc.DataMember);
            //dc.BaseClassMethod();
            //dc.DerivedClassMethod();
            //DerivedClass dc2 = new DerivedClass();
            //dc2.DataMember = 5;
            //Console.WriteLine("Value at bc = " + bc.DataMember);
            //Console.WriteLine("Value at dc = " + dc.DataMember);
            //Console.WriteLine("Value at dc2 = " + dc2.DataMember);


            ////Re-Instantiation
            //dc = new DerivedClass();
            //dc.DataMember = 12;
            //Console.WriteLine("Value at dc = " + dc.DataMember);


            //dc.DataMember = 15;
            //Console.WriteLine("Value at dc = " + dc.DataMember);


            #endregion



            #region Abstract Class Demo
            TestAbstract o = new TestAbstract();
            o._CarColor = "Red";
            Console.Write("\n\t"+o.ReturnHelloWorld());
            Console.Write("\n\t" + o.HelloMessage());
            o.HelloIMessage();
            Console.ReadKey();

            #endregion  

            #region Accessing Interface

            //AccesInterface app = new AccesInterface();
            //((Book)app).Next();

            //app.Previous();
            //app.Chapter();

            //((Channel)app).Next();

            ////////Console.Write("\nPress ENTER to quit...");
            //////Console.ReadLine();

            #endregion

            #region Inheriting Interface
            //InterfaceImplementer MyObj = new InterfaceImplementer();
            //MyObj.GetPersonalDetail();
            //MyObj.GetContactDetail();
            //MyObj.ShowDetail();

            #endregion

            #region Polymorphism

            #region Operator Overloading

            //int fNo, sNo;
            //Console.WriteLine("\nInput Two Numbers...Separate by Enter...");
            //fNo = int.Parse(Console.ReadLine());
            //sNo = int.Parse(Console.ReadLine());

            ////parameterized Constructor will be called in the following case....
            //MySpecialClass opr1 = new MySpecialClass(fNo, sNo);
            //Console.WriteLine("Before Operator Overloading");
            //Console.WriteLine("*****************************");
            //opr1.ShowData();

            ////Non-parameterized(default) Constructor will be called in the following case....
            //MySpecialClass opr2 = new MySpecialClass();
            //MySpecialClass opr3;

            //opr2 = -opr1; //It's perfect...Coz., - operator has been overloaded...
            //opr3 = -opr2;

            //Console.WriteLine("After Operator Overloading");
            //Console.WriteLine("---------------------------");
            //opr2.ShowData();
            //opr3.ShowData();

            //opr1 = new MySpecialClass(3, 4);
            //opr2 = new MySpecialClass(5, 7);
            //Console.WriteLine("After Operator Overloading");
            //Console.WriteLine("---------------------------");
            //opr3 = opr1 + opr2;
            //opr3.ShowData();
            //opr3 = opr1 * opr2;
            //opr3.ShowData();

            #endregion

            #region Function Overloading
            //Shape shape = new Shape();
            //shape.Area(15);
            //shape.Area(10.5);

            //shape.Area(15.5, 20.4);
            //shape.Area(10, 20);
            //////////Console.Write("\nPress ENTER to quit...");
            //////////Console.ReadLine();
            #endregion

            #region Function Overriding

            //Person p = new Person();
            //p.setAge(12);
            //AdultPerson ap = new AdultPerson();
            //Console.WriteLine("\nInput Adult Person's Age:- ");
            //int age = int.Parse(Console.ReadLine());
            //ap.setAge(age);
            //Console.Write("\n\tPersons Age: {0}\n\t And Adult Person's Age:{1}", p.getAge(), ap.getAge());

            //////////Console.ReadLine();

            #endregion

            #endregion

            Console.WriteLine("\n\t PRESS ANY KEY TO EXIT...");
            Console.ReadLine();
         
        }
    }

    #region Abstract Class
    class TestAbstract : Test, ITest
    {

        public void HelloIMessage()
        {
            Console.Write("\n\tCalled from Interface Implementation");
        }

        public override string HelloMessage()
        {
            return "Hello World...";
        }
    }
    #endregion
}
