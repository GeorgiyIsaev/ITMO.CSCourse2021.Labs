
namespace CSharp
{
    using System;
    
    public class Application
    {
        public static void Main(string[] args)
        {

            //generate token.cs > token.html
            Console.WriteLine("Колличество аргументов: " + args.Length);
            foreach (string ch in args)            
                Console.WriteLine(ch);            
            Console.ReadKey();


            try {               
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
