using System;
using VaporStore.Data;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VaporStoreContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
