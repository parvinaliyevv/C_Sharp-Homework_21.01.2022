using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            restart:

            DocumentProgram docProgram = null;
            string choice = null;

            Console.WriteLine("Enter one of the keywords (Basic, Pro, Expert):");
            choice = Console.ReadLine();

            if (choice.ToUpper() == "BASIC")
            {
                docProgram = new DocumentProgram();
            }
            else if (choice.ToUpper() == "PRO")
            {
                docProgram = new ProDocumentProgram();
            }
            else if (choice.ToUpper() == "EXPERT")
            {
                docProgram = new ExpertDocument();
            }
            else
            {
                Console.WriteLine("Wrong Choice");
                goto restart;
            }

            Console.Clear();
            docProgram.DocDelegate.Invoke();
        }
    }
}
