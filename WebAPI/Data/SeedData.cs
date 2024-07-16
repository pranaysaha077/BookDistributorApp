using Microsoft.EntityFrameworkCore.Infrastructure;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SeedData

    {

        public static void Initialize(WebAPIContext context)

        {

            if (context.Books.Any())

            {

                return;

            }



            var books = new Book[]

            {

            new Book

            {

                Title="Design Patterns: Elements of Reusable Object-Oriented Software",

                Price=1205,

                Publisher=new Publisher

                {

                    Name="Addison-Wesley Professional"

                },
                Tags = "Horor",
                PublishDate=new DateTime(1994,10,31),

                Authors = "Richard Helm;Erich Gamma;Ralph Johnson;John Vlissides"

            },

            new Book

            {

                Title="Stranger in a Strange Land",

                Price=2290,

                Publisher=new Publisher

                {

                    Name="Penguin Classics"

                },
                Tags = "Horor",
                PublishDate=new DateTime(2016,10,25),

                Authors = "Robert Heinlein"

            },

            new Book

            {

                Title="Masala Lab: The Science of Indian Cooking: The Science of Indian Cooking",

                Price=277,

                Publisher=new Publisher

                {

                    Name="Penguin Random House India"

                },
                Tags = "Horor",
                PublishDate=new DateTime(2020,12,14),

                Authors = "Krish Ashok"

            },

            new Book

            {

                Title="The Lucky List",

                Price=1142,

                Publisher=new Publisher

                {

                    Name="Simon & Schuster Books for Young Readers"

                },
                Tags = "Horor",
                PublishDate=new DateTime(2021,6,1),

                Authors = "Rachael Lippincott"

            },

            new Book

            {

                Title="Cemetery Boys",

                Price=1160,

                Publisher=new Publisher

                {

                    Name="Swoon Reads"

                },
                Tags = "Horor",
                PublishDate=new DateTime(2020,9,1),

                Authors = "Aiden Thomas"

            },

            new Book

            {

                Title="Atomic Habits",

                Price=468,

                Publisher=new Publisher

                {

                    Name="Random House Business Books"

                },
                Tags = "Horor",
                PublishDate=new DateTime(2018,10,30),

                Authors = "Atomic Habits",

            },

            new Book

            {

                Title="Ikigai: The Japanese secret to a long and happy life",

                Price=332,

                Publisher=new Publisher

                {

                    Name="Random House UK"

                },
                Tags = "Horor",
                PublishDate=new DateTime(2017,9,27),

                Authors = "Héctor García;Heather Cleary"

            }

            };

            context.Books.AddRange(books);

            context.SaveChanges();



            var publishers = new Publisher[]

            {

            new Publisher{Name = "O'Reilly Media"},

            new Publisher{Name="Hutchinson Heinemann"},

            new Publisher{Name="Viking"},

            new Publisher{Name="Manjul Publishing House"}

            };

            context.Publishers.AddRange(publishers);

            context.SaveChanges();

        }

    }
}
