using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacud_MP1
{
    internal class AddressBook
    {
        public string Name = "";
        public List<string> Contact = new List<string>();
        public List<string> Address = new List<string>();

        public AddressBook()
        {
            // I am thinking per file name?
        }
    }
}
