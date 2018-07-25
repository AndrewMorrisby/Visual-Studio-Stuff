using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordcount;

        public Book(string title, string author, int pages, int wordcount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordcount = wordcount;
        }

        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;

        }
        public void AssignWordCounFromText(string text)
        {
            wordcount = text.Split(' ').Length;
        }
    }
    
}
