
namespace CSharp
{
    using System;
    
    public class Application
    {
        public static void Main(string[] args)
        {
            try {
                Console.WriteLine(args.Length);
                InnerMain(args);
            }
            catch (System.Exception caught) {
                Console.WriteLine(caught);
            }
            Console.ReadKey();
        }
        
        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);

            HTMLTokenVisitor visitor = new HTMLTokenVisitor();
            source.Accept(visitor);
        }
    }
}
