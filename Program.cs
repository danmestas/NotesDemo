using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NotesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var db = new NotesContext())
             {
                 if(args.Length > 0 && args[0] == "CreateSeedData")
                 {
                     CreateSeedData(db);
                 }
                 else
                 {
                     ReadUncompletedNotes(db);
                 }
             }
        }

        private static void ReadUncompletedNotes(NotesContext db)
        {
            Console.WriteLine("Getting all the Uncompleted Notes...");
        }

        private static void CreateSeedData(NotesContext db)
        {
            Console.WriteLine("Generating seed data...");
        }
    }
}
