using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RCS_Tasks
{
    class FileIO
    {
        public static List<int> Read()
        {
            String line;
            List<int> a = new List<int>();
            try
            {
                StreamReader sr = new StreamReader("Test.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    a.Add(Convert.ToInt32(line));
                    line = sr.ReadLine();
                }
                sr.Close();
                return a;
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
                return null;
            }
        }

        public static void Write(List<int> a)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Test.txt", false);

                foreach (var item in a)                  
                    sw.WriteLine(item);

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}