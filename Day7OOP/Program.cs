using Day7OOP.Partial;
using Day7OOP.Static;
using System.Text;

namespace Day7OOP
{
    #region Exception Handling -- Custom Exception
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }
    #endregion
    internal class Program
    {

        #region Validate Email Method -- Exception Handling
        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new InvalidEmailException("Invalid Email Address");
            }
        }
        #endregion

        #region Swap Method -- Generics
        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}       
        //static var Sum( double x,  double y)
        //{
        //    return x + y;
        //}

        //anonymous types
        #endregion
        static void Main(string[] args)
        {
            #region Static Modifier

            #region Static Methods
            //Utility u1 = new Utility();
            //u1.X = 1;
            //u1.Y = 2;
            //Console.WriteLine(u1.MeterToCM(1.5));
            //Console.WriteLine(u1.CalcCircleArea(3));

            //u1.X = 10;
            //u1.Y = 20;
            //Console.WriteLine(u1.MeterToCM(1.5));
            //Console.WriteLine(u1.CalcCircleArea(3)); 


            //Console.WriteLine(Utility.MeterToCM(1.5));
            //Console.WriteLine(Utility.CalcCircleArea(3));
            #endregion

            #region Static Fields and Property
            //Utility u1 = new Utility();
            ////Console.WriteLine(u1.PI); //class memeber
            // Console.WriteLine(Utility.PI);
            // Console.WriteLine(Utility.CalcCircleArea(3.5));
            // //Console.WriteLine(Utility.PI);

            //u1.PI =

            //static 
            //Utility u1 = new Utility();

            #endregion

            #endregion

            #region Class Other Modifiers
            //Employee employee = new Employee();
            ////employee.print();
            //employee.Test();
            #endregion

            #region Shallow Copy And Deep Copy 
            /// shallow copy happens in stack
            /// copy refrences in stack then they refer to one object

            /// deep copy happens in heap
            /// create a new object in heap with the same instacne of the original object
            #region Array Of Value Type 

            #region Shallow Copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3];
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode()); //different locations in heap

            //arr1 = arr2; //shallow copy , now they refer to the same object in heap
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode()); // same location

            //arr1[0] = 10; // change the value in arr1
            //Console.WriteLine(arr1[0]); // 10
            //Console.WriteLine(arr2[0]); // 10 , same value in arr2 because they refer to the same object
            #endregion

            #region Deep Copy 
            //arr2 = (int[])arr1.Clone(); // deep copy
            //arr2 now refers to a new object in heap with the same values as arr1

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode()); // different locations in heap
            //created new object == arr1
            //took the ref , arr2 
            //arr1[0] = 20; // change the value in arr1
            //Console.WriteLine(arr1[0]); // 20
            //Console.WriteLine(arr2[0]); // 10 , different value in arr2 because they refer to different objects
            #endregion

            #endregion

            #region Array Of Reference Type 

            #region Immutable Reference Type [String]
            //string[] name01 = { "Omar", "Amr" };
            //string[] name02 = new string[3]; // { null, null, null };

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode()); // different locations in heap

            #region Shallow Copy
            //name02 = name01; // shallow copy , now they refer to the same object in heap (which is address to the string object)
            ////Console.WriteLine(name01.GetHashCode());
            ////Console.WriteLine(name02.GetHashCode()); // same location

            //name01[0] = "Sama";
            //Console.WriteLine(name01[0]); // Sama
            //Console.WriteLine(name02[0]); // Sama , same value in name02 because they refer to the same object
            #endregion

            #region Deep Copy
            //name02 = (string[]) name01.Clone(); // create a new object in heap with the same values as name01 object state which is addresses refering to the string objects
            ////Console.WriteLine(name01.GetHashCode());
            ////Console.WriteLine(name02.GetHashCode()); // different locations in heap
            //name01[0] = "Sama"; 
            //Console.WriteLine(name01[0]); // Sama
            //Console.WriteLine(name02[0]); // Omar , different value in name02 because they refer to different objects
            #endregion

            #endregion

            #region Mutable Reference Type [stringbuilder]
            //StringBuilder[] name01 = new StringBuilder[1];

            //name01[0] = new StringBuilder("omar");
            //StringBuilder[] name01 = [new StringBuilder("Omar")]; // collection expression , C#12;
            //StringBuilder[] name02 = new StringBuilder[2];

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode()); // different locations in heap

            #region Shallow Copy
            //name02 = name01; // shallow copy , now they refer to the same object in heap (which is address to the stringbuilder object)

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode()); // same location

            //name01[0].Append("Salma");
            //Console.WriteLine(name01[0]); //OmarSalma
            //Console.WriteLine(name02[0]); //OmarSalma , same value in name02 because they refer to the same object
            #endregion

            #region Deep Copy
            //name02 = (StringBuilder[])name01.Clone(); // create a new object in heap with the same values as name01 object state which is addresses refering to the stringbuilder objects

            ////Console.WriteLine(name01.GetHashCode());
            ////Console.WriteLine(name02.GetHashCode()); // different locations in heap

            //name01[0].Append("Salma");
            //Console.WriteLine(name01[0]); //OmarSalma
            //Console.WriteLine(name02[0]); //OmarSalma 
            #endregion

            #endregion

            #endregion

            #endregion

            #region Built in Interfaces + Copy Ctor

            #region ICloneable
            //BuiltInInterface.Employee employee1 = new BuiltInInterface.Employee() {Id = 10, Name= "Omar",Salary = 2000 };
            //BuiltInInterface.Employee employee2 = new BuiltInInterface.Employee() {Id = 20, Name= "Ali", Salary = 5000};

            //want to do deep copy?
            ////option 1: go implement ICloneable interface
            //employee1 = (BuiltInInterface.Employee)employee2.Clone();

            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);

            ////option 2: use copy constructor
            //employee1 = new BuiltInInterface.Employee(employee2); // copy constructor
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);
            #endregion

            #region IComparable
            //BuiltInInterface.Employee[] employees = {
            //    new BuiltInInterface.Employee() {Id = 10, Name= "Omar",Salary = 2000 },
            //    new BuiltInInterface.Employee() {Id = 20, Name= "Ali", Salary = 80000},
            //    new BuiltInInterface.Employee() {Id = 30, Name= "Ahmed", Salary = 5000},
            //    new BuiltInInterface.Employee() {Id = 40, Name= "nada", Salary = 10000},
            //};

            //Array.Sort(employees); //ascending order by salary
            //Array.Reverse(employees); //descending order by salary
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region IComparer
            //BuiltInInterface.Employee[] employees = {
            //    new BuiltInInterface.Employee() {Id = 10, Name= "Omar",Salary = 2000 },
            //    new BuiltInInterface.Employee() {Id = 20, Name= "Ali", Salary = 80000},
            //    new BuiltInInterface.Employee() {Id = 30, Name= "Ahmed", Salary = 5000},
            //    new BuiltInInterface.Employee() {Id = 40, Name= "nada", Salary = 10000},
            //};
            //// want to sort by name? Implement IComparer interface
            //// Another overload of Sort Method
            //Array.Sort(employees, new BuiltInInterface.EmployeeNameCompare());
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #endregion

            #region Generics
            //int x = 10; int y= 20;
            //Swap(ref x, ref y);
            //string s1 = "Ali";
            //string s2 = "omar";

            //Swap(ref s1, ref s2);
            #endregion

            #region var and dynamic
            // var ==> compile time
            // dynamic ==> runtime

            #region var
            ///var => used for implicilty typed variables (inferenance)
            ///The variable must be initialized at the time of declaration.
            ///Once the type is inferred, it cannot be changed(strongly typed).
            ///mostly used with LINQ queries, anonymous types, and when the type is obvious from the context.
            ///Limitations: 
            ///1- Cannot be used for fields, properties, or method parameters.
            ///2- Cannot be used with null values at declaration time.
            ///3- Cannot change the type after initialization.
            ///4- Cannot be used with out or ref parameters.
            ///5- Cannot ve used as a return type of a method.

            //var x = 20;
            //var y = "Amr";

            //var z;  //invalid, must be initialized at declaration time
            //z = 12; //invalid
            //x = "Ahmed"; //invalid, x is inferred as int and cannot be changed to string
            //var a = null; //invalid, cannot be initialized to null
            #endregion

            #region dynamic
            /// performance overhead
            /// used when the type is not known at compile time, such as when working with COM objects, reflection, or dynamic data sources.


            //dynamic x = 10;
            //x = new int[] { 1, 2, 3 };
            //x = "string";
            //dynamic z = null; // valid, can be initialized to null

            #endregion

            #endregion

            #region Exception Handling
            //try
            //{
            //    int num1 = 10;
            //    int num2 = 0;
            //    int result = num1 / num2;
            //    //int[] arr= new int[3];
            //    //arr[5];
            //}
            ////only 
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: Divide by zero");
            //    Console.WriteLine(ex.Message); //Attempted to divide by zero.
            //}
            //catch (Exception) {
            //    Console.WriteLine("Error: Unexpected Behaviour");
            //    //Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("This block will always execute");
            //}
            #region Custom Exception
            //try
            //{
            //    ValidateEmail("ahmed");
            //    //database statements
            //}
            //catch(InvalidEmailException ex) 
            //{
            //    //rollback database transaction
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}
            ////search on the difference between throw and throw ex;

            //Console.WriteLine("Can you access me?");
            #endregion

            #region Inner Exception
            //try
            //{
            //    try
            //    {

            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine(numbers[5]);
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        throw new Exception("An Error happeneed while accessing the array", ex);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message); // "An Error happeneed while accessing the array"
            //    Console.WriteLine("Inner Exception: " + e.InnerException?.Message); // "Index was outside the bounds of the array"
            //}
            #endregion

            #endregion
        }
    }
}
