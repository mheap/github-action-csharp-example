using System;
using System.Collections;

namespace NetCore.Docker
{
    class Program
    {
        static void Main(string[] args)
        {

            // Output environment variables
            Console.WriteLine("Environment Variables");
            Console.WriteLine("---------------------");
            foreach (DictionaryEntry e in System.Environment.GetEnvironmentVariables())
            {
                if (
                    !e.Key.ToString().StartsWith("GITHUB_") &&
                    !e.Key.ToString().StartsWith("INPUT_")
                )
                {
                    continue;
                }

                Console.WriteLine(e.Key + ": " + e.Value);
            }

            Console.WriteLine("");

            // Next, output the contents of event.json
            string path = System.Environment.GetEnvironmentVariable("GITHUB_EVENT_PATH");
            Console.WriteLine("Reading " + path);
            Console.WriteLine("---------------------");

            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine(text);
        }
    }
}