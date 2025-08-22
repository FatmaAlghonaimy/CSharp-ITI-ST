using Day6OOP.Abstraction;
using Day6OOP.Binding;
using Day6OOP.Interfaces;
using Day6OOP.Interfaces.Example01;
using Day6OOP.Interfaces.Example02;
using Day6OOP.Override;
using System;

namespace Day6OOP
{
    internal class Program
    {
        #region When Binding Happens
        public static void ProcessEmp(Employee employee)
        {
            employee.GetEmployeeData();
            employee.GetEmployeeType();
        }
        #endregion

        #region Interfaces
        static void PrintFiveFromSeries(ISeries series )
        {
            if (series is not null)
            {
                for (int i = 0; i < 5; i++)
                { 
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
            else
            {
                return;
            }

        }
        #endregion

        #region Abstraction Methods
        static void ProcessShape(Shape shape)
        {
            if (shape is not null)
            {
                Console.WriteLine($"Area {shape.CalcArea()}");
                Console.WriteLine($"Perimeter {shape.Perimeter}");
            }
        }
        static void Print2dShape(Shape shape)
        {

        }
        static void Print2dShape(I2dDraw shape) { }
        static void Print3dShape(I3dDraw shape) { }
        #endregion
        static void Main(string[] args)
        {

            #region Polymorphism - Overriding 


            //ClassA classA = new ClassA(10);
            //classA.MyFun01();
            //classA.MyFun02();

            //ClassB classB = new ClassB(10, 20);
            //classB.MyFun01(); 
            //classB.MyFun02();


            #endregion

            #region Binding 
            #region When Binding Happens 
            ////unexpected behaviour
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Ali", 20, 2000M);
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee(10, "Ali", 20, 20, 2000);
            //ProcessEmp(fullTimeEmployee);
            //ProcessEmp(partTimeEmployee);

            #endregion

            #region Simple Example

            //ClassA classA = new ClassB(10,20);
            //classA.A = 1;
            ////classA.B;
            //classA.MyFun01();
            //classA.MyFun02();
            #endregion

            #region Example 2

            //ClassD classD = new ClassD(10, 10, 20, 20);
            //classD.A = 10;
            //classD.B = 20;
            //classD.C = 20;
            //classD.D = 20;

            //classD.MyFun01();
            //classD.MyFun02();

            //ClassC classC = new ClassC(10, 20, 30);
            //classC.A = 10;
            //classC.B = 20;
            //classC.C = 30;

            //classC.MyFun01();
            //classC.MyFun02();

            //ClassC classC = new ClassD(10, 20, 30, 40);
            //classC.A = 10;
            //classC.B = 20;
            //classC.C = 30;
            ////classC.D 

            //classC.MyFun01();
            //classC.MyFun02();

            //ClassB classB01 = new ClassB(10, 20);
            //ClassB classB02 = new ClassC(10, 20, 30);
            //ClassB classB03 = new ClassD(10, 20, 30,40);


            //classB01.A = 10;
            //classB01.B = 20;

            //classB01.MyFun01();
            //classB01.MyFun02();

            //classB02.A = 10;
            //classB02.B = 20;

            //classB02.MyFun01();
            //classB02.MyFun02();

            //classB03.A = 10;
            //classB03.B = 20;
            ////classB02.c = 20;


            //classB03.MyFun01();
            //classB03.MyFun02();

            //ClassA classA01 = new ClassA(10);
            //ClassA classA02 = new ClassB(10,20);
            //ClassA classA03 = new ClassC(10,20,30);
            // ClassA classA04 = new ClassD(10,20,30,40);


            //classA01.A = 10;
            //classA02.B =10;
            //classA03.C =10;

            //classA01.MyFun01();
            //classA01.MyFun02();

            //classA02.A = 10;
            ////classA02.B =10;
            ////classA03.C =10;

            //classA02.MyFun01();
            //classA02.MyFun02();

            //classA03.A = 10;
            ////classA03.B = 10;
            ////classA03.C = 10;

            //classA03.MyFun01(); // new , data hiding , static polymorphism, compiler
            //classA03.MyFun02(); // virtual , dynamic , runtime

            //classA04.A = 10;
            //classA03.B = 10;
            //classA03.C = 10;

            //classA04.MyFun01(); // new , data hiding , static polymorphism, compiler
            //classA04.MyFun02(); // virtual , dynamic , runtime


            #endregion
            #endregion

            #region Interface 
            //can create reference? can create reference from interface to refer to an object that implements the interface
            //cant create instance from interface -- i dont have a constructor
            //IType ref;
            //IType type = new IType(); //ivalid

            #region 1- reference from Interface refering to abject that implements the interface
            //IType type = new ClassInterface(); // valid because ClassInterface implements IType interface

            #region Accessing Interface Members
            //string name = "Ali";
            //Console.WriteLine(type.MyProperty);
            //type.MyMethod();
            //type.Mythod02(name);
            #endregion

            #region Accessing ClassInterface Members
            //type.MyProperty = 10; //invalid -- its only get inside interface
            //type.MyMethod03(); //invalid 
            #endregion
            #endregion

            #region 1- reference from Class refering to abject that implements the interface
            //ClassInterface classInterface = new ClassInterface();

            #region Accessing Interface Members
            //string name = "Ali";
            //Console.WriteLine(classInterface.MyProperty);
            //classInterface.MyMethod();
            //classInterface.MyMethod02(name); //invalid -- default implemented method in interface
            #endregion

            #region Accessing ClassInterface Members
            //classInterface.MyProperty = 10; //valid 
            //classInterface.MyMethod03(); //valid 
            #endregion

            #endregion

            #endregion

            #region Interface Example 01
            //TypeA typeA = new TypeA();
            //PrintFiveFromSeries(typeA);

            //TypeB typeB = new TypeB();
            //PrintFiveFromSeries(typeB);

            #endregion

            #region Interface Example 02
            //Car car = new Car();
            //car.Speed = 100;
            //car.Backward(); // Move Car Backward
            //car.Forward();  // Move Car Forward
            //car.Left();     // Move Car Left
            //car.Right();    // Move Car Right


            //Airplane airplane = new Airplane();
            //airplane.Backward();
            //airplane.Forward(); //invalid , explicit implementation  How to access?? see next code

            //IMoveOnGround moveOnGround = new Airplane();
            //moveOnGround.Backward();
            //moveOnGround.Forward();
            //moveOnGround.Left();     // Move Car Left
            //moveOnGround.Right();    // Move Car Right

            //IMoveOnAir moveOnAir = new Airplane();
            //moveOnAir.Backward();
            //moveOnAir.Forward();
            //moveOnAir.Left();     // Move Car Left
            //moveOnAir.Right();    // Move Car Right

            #endregion

            #region Abstraction
            //Shape shape = new Shape(); 
            // invalid --  Cant create instance from abstract class however it have a constructor but used only for inhritance
            // Can only Create a Reference from it to refer to on abject that inherits the abstract class
            //Shape shape01 = new Rectangle(4,5);
            //Shape shape02 = new Square(4);
            //ProcessShape(shape01); //rectangle
            //ProcessShape(shape02); //square


            #region Class Test That inherits abstract class and implements the interface

            #region Refernce from Abstract Class 
            //Shape shape01 = new Test();

            #region accessing abstract class members //all valid
            //shape01.Dim01 = 10;
            //shape01.Dim02 = 20;
            //Shape.X = 20; //can access static members from abstract class
            //Console.WriteLine(shape01.Perimeter); 
            //shape01.CalcArea();
            #endregion

            #region Accessing Interface Members //invalidddd
            //string name = "Ali";
            //shape01.MyMethod(); //invalid
            //Console.WriteLine(shape01.MyProperty);
            //shape01.MyMethod02(name); //invalid -- default implemented method in interface
            #endregion

            #region Accessing Test Members //invaliddd
            //shape01.TestMethod(); //invalid
            #endregion

            #endregion

            #region Refernce from Interface
            //IType type01 = new Test();

            #region Accessing Interface Members // all valid
            //string name = "Ali";
            //type01.MyMethod(); //invalid
            //type01.MyMethod02(name); //invalid -- default implemented method in interface
            //Console.WriteLine(type01.MyProperty);
            #endregion

            #region accessing abstract class members //invalid
            //type01.Dim01 = 10;
            //type01.Dim02 = 20;
            //Console.WriteLine(type01.Perimeter);
            //type01.CalcArea();
            #endregion

            #region Accessing Test Members //invaliddd
            //type01.TestMethod(); //invalid
            #endregion

            #endregion

            #region Refernce from Test Class
            Test test = new Test();

            #region Accessing Test Members //valid
            //test.TestMethod();
            #endregion

            #region Accessing Interface Members
            //string name = "Ali";
            //test.MyMethod(); //valid
            //test.MyMethod02(name); //invalid -- default implemented method in interface
            //Console.WriteLine(test.MyProperty);
            #endregion

            #region accessing abstract class members //valid
            test.Dim01 = 10;
            test.Dim02 = 20;
            Console.WriteLine(test.Perimeter);
            test.CalcArea();
            #endregion
            #endregion
            #endregion

            #endregion
        }
    }
}
