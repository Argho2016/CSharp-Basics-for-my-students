using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // A method that is called when and instance of a class is created.
            //WHy? to put an object in an early state. initialize some of the fields in the class. 
        }
        public class customer
        {
            public string Name;
            public customer(string name)
            {
                //Constructor must have the same name as the class
                //they do not have a return type. not even void.
                //need to initialize an object upon creation. then use constructor.
                /*if you do not create a default constructor c# will create it for you in
                 * intermideate language code written. cannot be seen. it will initialize 
                 * the fields of the compiler to its deafult value. int = 0, bool=false. 
                 *this-->left side is a member of the class and right side is constructor.
                 */
                this.Name = name;
            }
        }
    }
}

/*Default Constructor
 * 
 * using System;
namespace DefaultConstractor
{
    class addition
    {
        int a, b;
        public addition()   //default contructor
        {
            a = 100;
            b = 175;
        }

        public static void Main()
        {
            addition obj = new addition(); //an object is created , constructor is called
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }
}

------------------------------------------------------------------------------

Parameterized Constructor

A constructor with at least one parameter is called a parameterized constructor. 
    The advantage of a parameterized constructor is that you can initialize each 
    instance of the class with a different value.

using System;
namespace Constructor
{
    class paraconstrctor
    {
      public  int a, b;
      public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
        {
            a = x;
            b = y;
        }
   }
    class MainClass
    {
        static void Main()
        {
            paraconstrctor v = new paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and ing values
            Console.WriteLine("-----------parameterized constructor example by vithal wadje---------------");
            Console.WriteLine("\t");
            Console.WriteLine("value of a=" + v.a );
            Console.WriteLine("value of b=" + v.b);
            Console.Read();
        }
    }
}
-----------------------------------------------------------------------------------

Copy constructor

The constructor which creates an object by copying variables from another 
    object is called a copy constructor. The purpose of a copy constructor 
    is to initialize a new instance to the values of an existing instance.

public employee(employee emp)
{
    name=emp.name;
    age=emp.age;
}

employee emp1=new  employee (emp2);


using System;
namespace copyConstractor
{
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)   // declaring Copy constructor.
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age)  // Instance constructor.
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get deatils of employee
        {
            get
            {
                return  " The age of " + name +" is "+ age.ToString();
            }
        }
    }
    class empdetail
    {
        static void Main()
        {
            employee emp1 = new employee("Vithal", 23);  // Create a new employee object.
            employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.
            Console.WriteLine(emp2.Details);
            Console.ReadLine();
        }
    }
}

----------------------------------------------------------------------------------
Static constructor

A static constructor does not take access modifiers or have parameters.
A static constructor is called automatically to initialize the class before the 
    first instance is created or any static members are referenced.
A static constructor cannot be called directly.
The user has no control over when the static constructor is executed in the program.
A typical use of static constructors is when the class is using a log file and 
    the constructor is used to write entries to this file.

class employee
{
    // Static constructor
    static employee(){}
}

using System;
namespace staticConstractor
{
    public class employee
    {
        static employee() // Static constructor
        declaration{Console.WriteLine("The static constructor ");
    }
    public static void Salary()
    {
        Console.WriteLine();
        Console.WriteLine("The Salary method");
    }
}
class details
{
    static void Main()
    {
        Console.WriteLine("----------Static constrctor example by vithal wadje------------------");
        Console.WriteLine();
        employee.Salary();
        Console.ReadLine();
    }
  }
}

-----------------------------------------------------------------------------

Private Constructor in C#

One use of a private constructor is when we have only static members.
It provides an implementation of a singleton class pattern
Once we provide a constructor that is either private or public or any, 
    the compiler will not add the parameter-less public constructor to the class.

using System;
namespace defaultConstractor
{
    public class Counter
    {
        private Counter()   //private constrctor declaration
        {
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++ currentview;
        }
    }
    class viewCountedetails
    {
        static void Main()
        {
            // Counter aCounter = new Counter();   // Error
            Console.WriteLine("-------Private constructor example by vithal wadje----------");
            Console.WriteLine();
            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.ReadLine();
        }
    }
}

*/



