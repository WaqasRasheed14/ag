using ApnaGhar.IServices;
using ApnaGhar.Models.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApnaGhar.Web.Api
{
    public class DbContextExtension
    {
        public static void SeedData(Data.AppDBContext context)
        {
            if (context.User.Any())
            {
                return;
            }
            var userList = new User[]
            {
                new User{FirstName="John", LastName="Mathew", Username="JohnMatheo", Gender=1, AboutMe="Oracle Inc", EmailAddress="JohnM@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                new User{FirstName="Jazy", LastName="Shawn", Username="JazyShawn", Gender=1, AboutMe="Shawn Co", EmailAddress="ShawnCo@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                new User{FirstName="Jameel", LastName="Sethi", Username="JameelSethi", Gender=1, AboutMe="Jameel Sons", EmailAddress="JameelSethi@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                new User{FirstName="Akhtar", LastName="Kamal", Username="KamalAkhtar", Gender=1, AboutMe="PCB", EmailAddress="KamalAkhtar@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                new User{FirstName="Maysum", LastName="Kamal", Username="Maysum", Gender=1, AboutMe="AGSD Pres", EmailAddress="Maysum@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},

            };
            foreach (var u in userList)
            {
                context.User.Add(u);
            }
            context.SaveChanges();
        }
    }
}
