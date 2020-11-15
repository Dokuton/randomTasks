using System;

namespace TestCases
{
    public struct ApiSetup<T> { }

    static class ApiSetupExtensions
    {
        internal static void SetupObjectA<T>(this ApiSetup<T> obj) where T : ISomeInterfaceA
        {
            Console.WriteLine("A object setup");
        }

        internal static void SetupObjectB<T>(this ApiSetup<T> obj) where T : ISomeInterfaceB
        {
            Console.WriteLine("B object setup");
        }
    }

    public class Api
    {
        public ApiSetup<T> For<T>(T obj)
        {
            return new ApiSetup<T>();
        }
    }


    interface ISomeInterfaceA { }
    interface ISomeInterfaceB { }


    public class ObjectA : ISomeInterfaceA { }
    public class ObjectB : ISomeInterfaceB { }


    class AnotherClass
    {
        public void Setup()
        {
            Api apiObject = new Api();

            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
        }
    }
}
