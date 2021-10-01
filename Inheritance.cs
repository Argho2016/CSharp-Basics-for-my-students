/* C# Single Level Inheritance Example: Inheriting Fields
using System;
public class Employee
{
    public float salary = 40000;
}
public class Programmer : Employee
{
    public float bonus = 10000;
}
class TestInheritance
{
    public static void Main(string[] args)
    {
        Programmer p1 = new Programmer();

        Console.WriteLine("Salary: " + p1.salary);
        Console.WriteLine("Bonus: " + p1.bonus);

    }
}
*/


/* C# Single Level Inheritance Example: Inheriting Methods
using System;
public class Animal
{
    public void eat() { Console.WriteLine("Eating..."); }
}
public class Dog : Animal
{
    public void bark() { Console.WriteLine("Barking..."); }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        Dog d1 = new Dog();
        d1.eat();
        d1.bark();
    }
}
*/


/* C# Multi Level Inheritance Example
using System;
public class Animal
{
    public void eat() { Console.WriteLine("Eating..."); }
}
public class Dog : Animal
{
    public void bark() { Console.WriteLine("Barking..."); }
}
public class BabyDog : Dog
{
    public void weep() { Console.WriteLine("Weeping..."); }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        BabyDog d1 = new BabyDog();
        d1.eat();
        d1.bark();
        d1.weep();
    }
}
*/