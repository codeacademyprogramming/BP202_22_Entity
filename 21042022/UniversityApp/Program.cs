using System;
using System.Collections.Generic;
using System.Linq;
using UniversityApp.Data.DAL;
using UniversityApp.Data.Entites;

namespace UniversityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityDbContext dbContext = new UniversityDbContext();


            //Create Group
            //Group group = new Group
            //{
            //    No = "AP201",
            //    StudentLimit = 18,
            //    StartDate = new DateTime(2020, 2, 20),
            //    LimitPoint = 50
            //};

            //dbContext.Groups.Add(group);
            //dbContext.SaveChanges();

            //Read All Group
            //List<Group> groups = dbContext.Groups.ToList();

            //foreach (var item in groups)
            //{
            //    Console.WriteLine($"{item.Id} - {item.No} - {item.StudentLimit}");
            //}


            //where
            //var groups = dbContext.Groups
            //    .Where(x => x.StudentLimit > 15)
            //    //.OrderByDescending(x => x.StudentLimit)
            //    .ToList();


            //foreach (var item in groups)
            //{
            //    Console.WriteLine($"{item.Id} - {item.No} - {item.StudentLimit}");
            //}

            //Read by id
            //var data = dbContext.Groups.Find(2);
            //var data = dbContext.Groups.FirstOrDefault(x => x.No == "AP205");
            //var data = dbContext.Groups.First(x => x.No == "AP205");
            //var data = dbContext.Groups.SingleOrDefault(x => x.No == "AP205");

            //Console.WriteLine($"{data.Id} - {data.No} - {data.StudentLimit}");

            //var data = dbContext.Groups.FirstOrDefault(x=>x.StudentLimit == dbContext.Groups.Max(x=>x.StudentLimit));

            //if (data != null)
            //{
            //    Console.WriteLine(data.StudentLimit);
            //}

            var data = dbContext.Groups.FirstOrDefault(x => x.Id == 2);

            //if(data != null)
            //{
            //    data.StudentLimit = 25;
            //}

            //dbContext.SaveChanges();

            dbContext.Groups.Remove(data);

            dbContext.SaveChanges();


        }
    }
}
