
using DelegateDemo;

Console.WriteLine("Delegate Demo");
operation obj = new operation(DelegateDemo1.Addition);   
Console.WriteLine("Addition is = {0}",obj.Invoke(23,27));
MulticastDelegate1.ImplementDelegate();
Console.ReadKey();