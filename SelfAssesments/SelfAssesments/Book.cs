using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesments
{
    class Book
    {
        public string author;
        public int pages;
        public List<string> chapters = new List<string>();
        public int bookMark;
        public int price;
      public void AddChapterToList(string chapter)
        {
            chapters.Add(chapter);
        }
        public Book(string author, int pages,int bookMark,int price)
        {
            this.author = author;
            this.pages = pages;
            this.bookMark = bookMark;
            this.price = price;
        }
        public string GetChapter(int chapterNumber)
        {
            return chapters[chapterNumber - 1];
        }
        public int GetBookMark()
        {
            return bookMark;
        }
        public void SetBookMark(int BookMarknew)
        {
            this.bookMark = BookMarknew;
            Console.WriteLine("New Book mark is at : " + this.bookMark);
        }
        public int Getprice()
        {
            return this.price;
        }
        public void SetBookPrice(int PriceNew)
        {
            this.price = PriceNew;
            Console.WriteLine("New Price: " + this.price);

        }

    }
}
