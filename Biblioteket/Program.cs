using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a assignment for school

            //variable
            string bookOfInterest;
            bool exit = false;

            //Makeing a lots of books
            Book got1 = new Book("Game of throne", "Gorage RR Martin", "Fantacy", 856, true);
            Book got2 = new Book("Clas of kings", "Gorage RR Martin", "Fantacy", 543, true);
            Book got3 = new Book("A storm of swords", "Gorage RR Martin", "Fantacy", 727, true);
            Book got4 = new Book("A feast for crows", "Gorage RR Martin", "Fantacy", 652, true);
            Book got5 = new Book("Dance of dragons", "Gorage RR Martin", "Fantacy", 988, true);
            Book hp1 = new Book("Harry Potter 1", "J.R.R.", "Fairytale", 315, true);
            Book hp2 = new Book("Harry Potter 2", "J.R.R.", "Fairytale", 348, true);
            Book hp3 = new Book("Harry Potter 3", "J.R.R.", "Fairytale", 412, true);
            Book hp4 = new Book("Harry Potter 4", "J.R.R.", "Fairytale", 555, true);
            Book hp5 = new Book("Harry Potter 5", "J.R.R.", "Fairytale", 745, true);
            Book hp6 = new Book("Harry Potter 6", "J.R.R.", "Fairytale", 579, true);
            Book hp7 = new Book("Harry Potter 7", "J.R.R.", "Fairytale", 658, true);

            //list for the books what are in hause, and adds the books to the list
            List<Book> inHouse = new List<Book>()
            {
                got1, got2, got3, got4, got5, hp1, hp2, hp3, hp4, hp4, hp5, hp6, hp7
            };

            //create a object form the library class
            Libraty libraty = new Libraty();

            //Stack for the books going out on loan
            Stack<Book> outToLoan = new Stack<Book>();

            //loop to keep the program running
            do
            {
                //shows the librarys gui
                libraty.GuiLibraty();

                //ReadLine() to take the userinput
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    //if the user presses 1
                    case 1:

                        //loops though the list and output the result
                        foreach (Book b in inHouse.OrderBy(d => d.Title))
                        {
                            Console.WriteLine(b);
                        }

                        //break out
                        break;

                    //if the user presses 2
                    case 2:

                        //output to the user
                        Console.WriteLine("write the name, on book du you wish to loan?");

                        //set the bookOfInterest variable to read the user input
                        bookOfInterest = Console.ReadLine().ToLower();

                        Book bookToLoan = inHouse.FirstOrDefault(d => d.Title.ToLower() == bookOfInterest);

                        if (bookToLoan != null)
                        {
                            outToLoan.Push(bookToLoan);
                            Console.WriteLine(outToLoan.Peek());
                            inHouse.Remove(bookToLoan);
                        }

                        //get back to the library menu
                        libraty.Back();

                        //break out
                        break;

                    //if the user presses 3
                    case 3:

                        //add the object to the inHouse list
                        inHouse.Add(outToLoan.First());

                        //remove the first object in outToLoan
                        outToLoan.Pop();

                        //get back to the library menu
                        libraty.Back();

                        //break out
                        break;

                    //if the user presses 4
                    case 4:

                        exit = true;

                        break;

                    default:
                        break;
                }

            } while (!exit);
        }
    }
}
