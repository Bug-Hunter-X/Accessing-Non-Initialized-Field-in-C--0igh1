public class ExampleClass
{
    private int _myValue;

    // Constructor to initialize the field
    public ExampleClass()
    {
        _myValue = 0; // Initialize to a default value
    }

    public int MyProperty
    {
        get { return _myValue; }
        set { _myValue = value; }
    }

    public void MyMethod()
    {
        Console.WriteLine(_myValue); // Now _myValue is initialized
    }
} 