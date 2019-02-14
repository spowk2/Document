using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.Write("Enter the name of the document: ");
            string name = Console.ReadLine();
            Console.Write("Enter the content of the document: ");
            string content = Console.ReadLine();
            try
            {
                StreamWriter streamWriter = new StreamWriter(name + ".txt");
                streamWriter.WriteLine(content);
                streamWriter.Close();
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", name, content.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        
    }
}