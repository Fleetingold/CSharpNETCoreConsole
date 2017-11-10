using System;
public class MyClass
{

    //[Obsolete("Don't use OldMethod, use NewMethod instead", true)]
    [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
        Console.ReadKey();
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }
    //public static void Main()
    //{
    //    OldMethod();
    //}
}