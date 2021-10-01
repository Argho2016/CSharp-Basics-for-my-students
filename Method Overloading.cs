//Having two or more methods with same name but different in parameters,
//is known as method overloading in C#. The advantage of method overloading
//is that it increases the readability of the program because you don't need
//to use different names for same action.You can perform method overloading in
//C# by two ways: By changing number of arguments
//By changing data type of the arguments


// C# Method Overloading Example: By changing no. of arguments
/*
using System;

public class Cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
}
public class TestMemberOverloading
{
    public static void Main()
    {
        Console.WriteLine(Cal.add(12, 23));
        Console.WriteLine(Cal.add(12, 23, 25));
    }
}
*/


//C# Member Overloading Example: By changing data type of arguments
using System;
public class Cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static float add(float a, float b)
    {
        return a + b;
    }
}
public class TestMemberOverloading
{
    public static void Main()
    {
        Console.WriteLine(Cal.add(12, 23));
        Console.WriteLine(Cal.add(12.4f, 21.3f));
    }
}