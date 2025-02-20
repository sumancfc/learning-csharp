# General Structure of a C# Program

### Example

```csharp
// A skeleton of a C# program
using System;

namespace YourNamespace
{
    class YourClass {}
    
    struct YourStruct {}
    
    interface IYourInterface {}
    
    delegate int YourDelegate();
    
    enum YourEnum {}
    
    namespace YourNestedNamespace {
        struct YourStruct {}
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello"");
        }
    }
}
```

## Main() and command-line arguments

Main method is a entry point of a C# application. When the application is started, the `Main` method is the first method that is invoked.

### Example

```csharp
class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
    }
}
```