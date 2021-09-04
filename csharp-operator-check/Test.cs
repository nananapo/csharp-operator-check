public class Test
{
    static void Main(string[] args)
    {
        A a = new B();
        B b = new B();

        var d = a + b;
    }
}

public class A
{
    public static implicit operator B(A a) => new B();

    public static A operator -(A a, A a2) => a;
}

public class B
{
    public static implicit operator A(B b) => new A();
        
    public static B operator +(B a, B a2) => a;
}