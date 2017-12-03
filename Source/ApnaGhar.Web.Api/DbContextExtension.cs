using ApnaGhar.Data;
using ApnaGhar.IServices;
using ApnaGhar.Models;
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
        public static void SeedData(AppDBContext context)
        {
            if (!context.User.Any())
            {
                var userList = new User[]
                {
                    new User{FirstName="John", LastName="Mathew", Username="JohnMatheo", Gender=1, AboutMe="Oracle Inc", EmailAddress="JohnM@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                    new User{FirstName="Jazy", LastName="Shawn", Username="JazyShawn", Gender=1, AboutMe="Shawn Co", EmailAddress="ShawnCo@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                    new User{FirstName="Jameel", LastName="Sethi", Username="JameelSethi", Gender=1, AboutMe="Jameel Sons", EmailAddress="JameelSethi@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                    new User{FirstName="Akhtar", LastName="Kamal", Username="KamalAkhtar", Gender=1, AboutMe="PCB", EmailAddress="KamalAkhtar@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"},
                    new User{FirstName="Maysum", LastName="Kamal", Username="Maysum", Gender=1, AboutMe="AGSD Pres", EmailAddress="Maysum@yahoo.com", DateOfBirth=Convert.ToDateTime("1/14/1989"),HashedPassword="d6b0ab7f1c8ab8f514db9a6d85de160a"}
                };
                foreach (var u in userList)
                {
                    context.User.Add(u);
                }
                context.SaveChanges();
            }

            if (!context.FAQCategory.Any())
            {
                var faqCategoryList = new FAQCategory[]
                    {
                        // FAQCategoryID=1, To Ask 
                        new FAQCategory{ FAQCategoryName="Finding a place", FAQCategoryDescription="How to find a place, reserve it, and coordinate details with your host. Learn how to search for places by specific characteristics like neighborhood or room type, how long a host has to respond to your request, and when and how you should send a host a message"},
                        new FAQCategory{ FAQCategoryName="Payment", FAQCategoryDescription="Learn how to pay, when you’re charged, and how to fix payment issues"},
                        new FAQCategory{ FAQCategoryName="Becoming a host", FAQCategoryDescription="See what’s required to host a home or experience, and how to create an listing for it on ApnaGhar"},
                    };
                foreach (var item in faqCategoryList)
                {
                    context.FAQCategory.Add(item);
                }
                context.SaveChanges();                
            }

            if (!context.FAQ.Any())
            {
                var faqsList = new FAQ[]
                    {
                        new FAQ{ FAQCategoryID=9, QuestionText="How do I search for a place to stay on ApnaGhar?", Answer="When you search for a place to stay on Airbnb, you can narrow your options by using filters and reading the descriptions of places to check if they’d be a good fit for your trip."},
                        new FAQ{ FAQCategoryID=9, QuestionText="How do I use search filters on ApnaGhar?", Answer="For the most accurate results, always start your search by choosing your destination, number of guests, and dates. Other filters are available as well, some of which can be found by selecting More Filters below the filters that are showing."},
                        new FAQ{ FAQCategoryID=9, QuestionText="How do I manage my Wish List on ApnaGhar?", Answer="You can share a Wish List with the people you want to travel with and allow them to add listings and notes to the list."},

                        new FAQ{ FAQCategoryID=10, QuestionText="Do I get a full refund if I cancel?", Answer="If you cancel a reservation, your refund amount is determined by your host’s cancellation policy and how close to your trip you are at the time of your cancellation. If you’d like to request a bigger refund from your host you can send a request through our Resolution Center. Any additional refund will be at your host's discretion."},
                        new FAQ{ FAQCategoryID=10, QuestionText="When am I charged for a reservation?", Answer="Your payment information is collected when you submit a reservation request. Once the host accepts your request, or if you book a reservation with Instant Book, your payment method will be charged for the entire amount at that time. Whether the reservation is two days or two months away, we hold the payment until 24 hours after check-in before giving it to the host. This hold gives both parties time to make sure that everything is as expected."},
                        new FAQ{ FAQCategoryID=10, QuestionText="How do I edit or remove my payment method?", Answer="If you choose to pay with a credit card when you make a reservation request, you can edit or remove the credit card information from your Airbnb account later, as long as a default payment method remains."},

                        new FAQ{ FAQCategoryID=11, QuestionText="How do I create a listing on ApnaGhar?", Answer="You can create a listing in the Host section of your profile. After you publish your listing, it may take up to 6 hours for it to appear in search results."},
                        new FAQ{ FAQCategoryID=11, QuestionText="What legal and regulatory issues should I consider before hosting on ApnaGhar?", Answer="Some cities have laws that restrict your ability to host paying guests for short periods. These laws are often part of a city's zoning or administrative codes. In many cities, you must register, get a permit, or obtain a license before you list your property or accept guests. Certain types of short-term bookings may be prohibited altogether. Local governments vary greatly in how they enforce these laws. Penalties may include fines or other enforcement."},
                        new FAQ{ FAQCategoryID=11, QuestionText="Who can host on ApnaGhar?", Answer="Almost anyone can be a host! It's free to sign up and list your space. The listings available on the site are as diverse as the hosts who list them, so you can post airbeds in apartments, entire houses, rooms in bed-and-breakfasts, tree houses in the woods, boats on the water, or enchanted castles. Find out more about room types to see how to describe your space."},
                    };
                foreach (var item in faqsList)
                {
                    context.FAQ.Add(item);
                }
                context.SaveChanges();
            }

        }
    }
}
