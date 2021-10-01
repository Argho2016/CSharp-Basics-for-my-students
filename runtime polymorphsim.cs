//The term "Polymorphism" is the combination of "poly" + "morphs" which
//means many forms. It is a greek word. In object-oriented programming,
//we use 3 main concepts: inheritance, encapsulation and polymorphism.
//There are two types of polymorphism in C#: compile time polymorphism
//and runtime polymorphism. Compile time polymorphism is achieved by method
//overloading and operator overloading in C#. It is also known as static
//binding or early binding. Runtime polymorphism in achieved by method overriding
//which is also known as dynamic binding or late binding.

/*using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("eating...");
    }
}
public class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("eating bread...");
    }

}
public class TestPolymorphism
{
    public static void Main()
    {
        Animal a = new Dog();
        a.eat();
    }
}
*/


/*
using System;
public class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing...");
    }
}
public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }

}
public class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing circle...");
    }

}
public class TestPolymorphism
{
    public static void Main()
    {
        Shape s;
        s = new Shape();
        s.draw();
        s = new Rectangle();
        s.draw();
        s = new Circle();
        s.draw();

    }
}
*/


//Runtime Polymorphism can't be achieved by data members in C#.
//Let's see an example where we are accessing the field by reference
//variable which refers to the instance of derived class.

using System;
public class Animal
{
    public string color = "white";

}
public class Dog : Animal
{
    public string color = "black";
}
public class TestSealed
{
    public static void Main()
    {
        Animal d = new Dog();
        Console.WriteLine(d.color);

    }
}
