using Day7OOP.Partial;
using Day7OOP.Static;
using System.Text;

namespace Day7OOP
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }
    internal class Program
    {
        #region Swap
        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new InvalidEmailException("Invalid Email Address");
            }
        }

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

            #region Class Other Keywords
            //Employee employee = new Employee();
            ////employee.print();
            //employee.Test();
            #endregion

            #region Shallow Copy And Deep Copy 
            // shallow , instance  Employee 10, al, 2000

            #region Array Of Value Type 

            #region Shallow Copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3];
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr1 = arr2; //shallow copy 
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            #endregion

            #region Deep

            //arr2 = (int[])arr1.Clone(); // deep copy

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //created new object == arr1  
            //took the ref , arr2 
            #endregion


            #endregion

            #region Array Of Reference Type 

            #region Immutable Reference Type [String]
            //string[] name01 = { "Omar", "Amr" };
            //string[] name02 = new string[3];

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            #region Shallow
            //name02 = name01;
            ////Console.WriteLine(name01.GetHashCode());
            ////Console.WriteLine(name02.GetHashCode());

            //name01[0] = "Sama";
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);
            #endregion

            #region Deep
            //name02 = (string[]) name01.Clone();
            ////Console.WriteLine(name01.GetHashCode());
            ////Console.WriteLine(name02.GetHashCode());
            //name01[0] = "Sama";
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);
            #endregion



            #endregion

            #region Mutable Reference Type [stringbuilder]
            //StringBuilder[] name01 = new StringBuilder[1];

            //name01[0] = new StringBuilder("omar");
            //StringBuilder[] name01 = [new StringBuilder("Omar")]; // collection expression , C#12;
            //StringBuilder[] name02 = new StringBuilder[2];


            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            #region Shallow
            //name02 = name01;

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            //name01[0].Append("Salma");
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);
            #endregion

            #region deep
            //name02 = (StringBuilder[])name01.Clone();

            //name01[0].Append("Salma");
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);
            #endregion

            #endregion


            #endregion

            #endregion

            #region Built in Interfaces + Copy Ctor
            //BuiltInInterface.Employee employee1 = new BuiltInInterface.Employee() {Id = 10, Name= "Omar",Salary = 2000 };
            //BuiltInInterface.Employee employee2 = new BuiltInInterface.Employee() {Id = 20, Name= "Ali", Salary = 5000};


            //employee1 = (BuiltInInterface.Employee)employee2.Clone();
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);

            #region IComparable
            //BuiltInInterface.Employee[] employees = {
            //    new BuiltInInterface.Employee() {Id = 10, Name= "Omar",Salary = 2000 },
            //    new BuiltInInterface.Employee() {Id = 20, Name= "Ali", Salary = 80000},
            //    new BuiltInInterface.Employee() {Id = 30, Name= "Ahmed", Salary = 5000},
            //    new BuiltInInterface.Employee() {Id = 40, Name= "nada", Salary = 10000},
            //};
            #endregion
            #region IComparer

            //Array.Sort(employees);
            ////Array.Reverse(employees);
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
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

            // var compile time
            // dynamic runtime

            //var
            //int a = 10;
            //var x = 20;
            //var y = "Amr";

            //var z;  
            //z = 12; //invalid
            //x = "Ahmed";

            //linq 

            // performance overhead
            // reflection , plugins

            //dynamic x = 10;
            //x = new int[] { 1, 2, 3 };
            //x = "string";

            #endregion

            #region exception handling
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
            //    Console.WriteLine("This bolck will always execute");
            //}

            //try
            //{
            //    ValidateEmail("ahmed");
            //    //database statements
            //}
            //catch(InvalidEmailException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}
            ////search on the difference between throw and throw ex;
            //Console.WriteLine("Can you access me?");

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
            //    Console.WriteLine(e.Message);
            //}

            #endregion
        }
    }          
}

//dll -- reflection -- plugins