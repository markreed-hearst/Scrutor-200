namespace Scrutor.Repro
{
    public interface ISayHelloToTheWorld
    {
        public string Speak();
    }

    public class HelloWorld: ISayHelloToTheWorld
    {
        public string Speak() => "Hello, World!";
    }
}