using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BOOK LOTR = new BOOK();
            LOTR.SetTitlez("idiot");
            LOTR.VlastnostPagesz(666);
            LOTR.SetCategorz("Balalajka");
            LOTR.SetAuthorz("Janči");
            LOTR.VlastnostReleaseDatez(564156);
            LOTR.Hiolp();
        }
    }
    class BOOK
    {
        string M = " ";
        string title;
        int pages;
        string category;
        string author;
        int releaseDate;
        public void SetTitlez(string a)
        {
            title = a;
        }
        public void VlastnostPagesz(int b)
        {
            if (b < 0)
            {
                pages = 1;
            }
            else
            {
                pages = b;
            }
        }
        public void SetCategorz(string c)
        {
            category = c;
        }
        public void SetAuthorz(string d)
        {
            author = d;
        }
        public void VlastnostReleaseDatez(int e)
        {
            if ( e<1450 || e > 2021)
            {
                releaseDate = -1;
            }
            else
            {
                releaseDate = e;
            }
        }
        public void Hiolp()
        {
            Console.WriteLine(title + M + pages + M + category + M + author + M + releaseDate);
        }
    }
}