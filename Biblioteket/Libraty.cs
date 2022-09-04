using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Libraty
    {
        public void GuiLibraty()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                      Welcome to the library");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. List of book, ready to loan");
            Console.WriteLine("2. Loan a book");
            Console.WriteLine("3. Delivering a loaned book back");
            Console.WriteLine("4. Exit the library");
            Console.WriteLine();
            Console.WriteLine("Choose your number");
        }

        public void Back()
        {
            Console.WriteLine();
            Console.WriteLine("For returning to the menu, please press Enter");
            Console.WriteLine();
        }
    }
}
