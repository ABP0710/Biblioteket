using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteket
{
    internal class Book
    {
        private string title;
        private string author;
        private string genres;
        private int pages;
        private bool hardBack;


        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Genres { get { return genres; } set { genres = value; } }
        public int Pages { get { return pages; } set { pages = value; } }
        public bool HardBack { get { return hardBack; } set { hardBack = value; } }


        public Book(string title, string author, string genres, int pages, bool hardBack)
        {
            this.Title = title;
            this.Author = author;
            this.Genres = genres;
            this.Pages = pages;
            this.HardBack = hardBack;
        }

        ////override tostring
        public override string ToString()
        {
            return title;
        }
    }
}
