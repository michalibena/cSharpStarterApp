using System;

namespace cSharpStarterApp
{
    // our wrapper class to simply run our code as modeled by the classes.
    //
    // What did we learn today:
    // classes, objects, instantiation, ctors, fields, properties, get/set methods,
    // access modifiers (private/public), class methods, string class,
    // override the object base class to print out the class for debugging,
    // override demonstrates C#'s ability to do polymorphism, an OO characteristic
    class Program
    {
        static void Main(string[] args)
        {
            int loopLength = 5;
            string message = "Hello, World!";

            // worker is an object reference to the class Worker;
            // the Worker ctor instantiates the object worker.
            Worker worker = new Worker(loopLength, message);
            Console.WriteLine(worker);
            worker.doWork();
        }
    }
}
