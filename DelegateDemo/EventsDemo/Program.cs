using EventsDemo;


Console.WriteLine("Hello, World!");

EventsSample.add += new DelEventHandler(EventsSample.India);
EventsSample.add += new DelEventHandler(EventsSample.USA);
EventsSample.add += new DelEventHandler(EventsSample.England);
EventsSample.add -= new DelEventHandler(EventsSample.USA);
EventsSample.Test();
Console.WriteLine("*****Event Handling*****");
EventHandling.ImplementEvent();
Console.ReadKey();