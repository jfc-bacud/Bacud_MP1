using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2425_WordCount_2A
{
    static internal class FileManager
    {
        public static bool Read(string fileName, out List<string> content, out int contactNum)
        {
            content = new List<string>();

            if (File.Exists(Directory.activeDir + fileName))
            {
                using (StreamReader sr = new StreamReader(Directory.activeDir + fileName))
                {
                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        content.Add(line);
                    }
                }
                contactNum = content.Count;
                return true;
            }

            contactNum = 0;
            return false;
        }

        public static void Write(string fileName, List<string> content, bool append = false) 
        {
            using (StreamWriter sw = new StreamWriter(Directory.activeDir + fileName, append))
            {
                foreach (string c in content)
                {
                    sw.WriteLine(c);
                }
            }
        }
    }
}
