using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 2)
            {
                Console.WriteLine("Usage:  FileWriter <FileName> \"Message\"");
                return;
            }            

            string filename = args[0];
            string message = args[1];

            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(message);
            sw.Flush();
            sw.Close();

            Console.WriteLine("File Created Successfully");

            return;

        }
    }
}
