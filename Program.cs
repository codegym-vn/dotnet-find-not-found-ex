using System;
using System.IO;

namespace dotnet_find_not_found_ex
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Read in nonexistent file.
                using (StreamReader reader = new StreamReader("not-there.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }
    }
}
