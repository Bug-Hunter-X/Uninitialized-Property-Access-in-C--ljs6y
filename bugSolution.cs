public class MyClass
{
    public int MyProperty { get; set; } = 10; // Initialize MyProperty directly

    public MyClass()
    {
        MyProperty = 10; // Initialize in the constructor
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty will have the value you want
    }
}