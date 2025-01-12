public class ExampleClass
{
    private int _myValue;

    public int MyProperty
    {
        get { return _myValue; }
        set { _myValue = value; }
    }

    public void MyMethod()
    {
        // Accessing a non-initialized field in a constructor
        Console.WriteLine(_myValue); 
    }
}