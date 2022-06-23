using System;
class GFG
{
    static public void Main()
    {
        /*int G;
        Sum(out G); //here sum is a method
        Console.WriteLine("The sum of" +
                " the value is: {0}", G);
        */

        string str = "aiub";
        SetValue(ref str); //here setvalue us a method
        Console.WriteLine(str);
    }

    public static void Sum(out int G)
    {
        G = 80;
        G += G;
    }

    static void SetValue(ref string str1)
    {
        if (str1 == "aiub")
        {
            Console.WriteLine("Parameter value checked");
        }
       str1 = "Hello World";
    }
}