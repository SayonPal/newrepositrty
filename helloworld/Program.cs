// See https://aka.ms/new-console-template for more information
namespace helloworld
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello, World!");
            Fibonocciseries series = new Fibonocciseries();
            series.Findfibonocciseries();
            Console.Read();
            
        }
    }
}