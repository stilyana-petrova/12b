using BookShopSchool.Models;
using System;

namespace BookShopSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BookShopSchoolContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
