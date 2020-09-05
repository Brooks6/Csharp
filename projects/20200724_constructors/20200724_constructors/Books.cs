using System;
namespace _20200724_constructors
{
    public class Books
    {
        public Books(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public string title;
        public string author;
        public int pages;
    }
}
