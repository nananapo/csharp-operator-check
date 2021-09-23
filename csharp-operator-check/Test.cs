using System;
using System.Security.Cryptography.X509Certificates;

public class Test
{
    static void Main(string[] args)
    {
        A a = new A();
        var c = a + a;
        Console.WriteLine(c.GetType().Name);
    }
}

public class A
{
    public static implicit operator long(A a) => 0;
    public static implicit operator float(A a) => 0;
}