using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// file handling stuff

namespace Thurs251400
{
    class MyUtils
    {
        // method to write to a file
        public static void WriteToFile(string fullFileName, string StuffToWrite)
        {
            // construct to open the file, write to it and then close it.
            // clean up after closing.
            using (var writer = new StreamWriter(fullFileName, false))
            {
                writer.WriteLine(StuffToWrite);
            }
            // once I get to here, writer is disposed of
        }

        // method to read from a file
        public static string ReadFromFile(string fullFileName)
        {
            string readText;
            // file access problem (permissions), doesn't exist, already open
            try
            {
                // open the file
                using (var reader = new StreamReader(fullFileName))
                {
                    readText = reader.ReadToEnd();
                }
            }
            catch
            {
                // fails - default text to say couldn't read
                readText = "Could not open that file";
            }
            return readText;
        }
    }
}
