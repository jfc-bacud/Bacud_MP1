using OOP_2425_WordCount_2A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacud_MP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            AddressBook[] contacts = new AddressBook[] { };
            int contactNum = 0;

            UserInput userInput = new UserInput();

            while (true)
            {
                Console.Clear();
                FileManager.Read(Directory.mainList, out list, out contactNum);
                Console.WriteLine($"Address Book contains {contactNum} contacts ");

                userInput.ChoiceSelection();

                Console.ReadKey();
            }



           
        }
    }
}
