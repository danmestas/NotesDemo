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
                 if(args.Length > 0 && args[0] == "CreateSampleData")
                 {
                     CreateSampleData(db);
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
            // var assignments = db.Users.AsNoTracking()
            //             .Where(ca => ca.Year == 2020)
            //             .Include(ca => ca.Bed).ThenInclude(b => b.Garden)
            //             .Include(ca => ca.Crop)
            //             .OrderBy(ca => ca.Bed.Garden.Name).ThenBy(ca => ca.Crop.Name).ThenBy(ca => ca.Bed.Number)
            //             .ToList();
            // assignments.ForEach(a => Console.WriteLine($"Growing {a.Crop.Name} on bed {a.Bed.Number} in the garden {a.Bed.Garden.Name}"));
        }

        private static void CreateSampleData(NotesContext db)
        {
            var user1 = (db.Users.Add(new User { Username = "dmestas", Title = "Needs Coordinator" })).Entity;
            db.SaveChanges();
            var user2 = (db.Users.Add(new User { Username = "acharanv", Title = "Needs Coordinator" })).Entity;
            db.SaveChanges();
            var user3 = (db.Users.Add(new User { Username = "adavis", Title = "Needs Coordinator", IsAdmin = true })).Entity;
            db.SaveChanges();
            var user4 = (db.Users.Add(new User { Username = "efabianski", Title = "Needs Coordinator" })).Entity;
            db.SaveChanges();
        }
    }
}
