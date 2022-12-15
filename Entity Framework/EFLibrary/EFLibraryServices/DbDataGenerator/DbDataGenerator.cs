using System;
using System.Collections.Generic;
using System.Linq;
using EFLibraryPersistence;
using EFLibraryPersistence.Models;

namespace EFLibraryServices.DbDataGenerator
{
    public class DbDataGenerator
    {
        private EfLibraryDbContext _dbContext;

        public DbDataGenerator(EfLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void GenerateData()
        {
            GenerateAuthors();
            GenerateBooks();
            GenerateUsers();
            GenerateUserBooks();
        }

        private void GenerateAuthors()
        {
            if (!_dbContext.Authors.Any())
            {
                _dbContext.Authors.AddRange(new List<Author>()
                {
                    new Author()
                    {
                        FirstName = "Aldous",
                        LastName = "Huxley",
                        Country = "UK",
                        BirthDate = new DateTime(1894, 07, 26)
                    },
                    new Author()
                    {
                        FirstName = "Fyodor",
                        LastName = "Dostoevsky",
                        Country = "Russia",
                        BirthDate = new DateTime(1821, 11, 11)
                    },
                    new Author()
                    {
                        FirstName = "Harper",
                        LastName = "LEE",
                        Country = "USA",
                        BirthDate = new DateTime(1926, 04, 28)
                    },
                    new Author()
                    {
                        FirstName = "Charlotte",
                        LastName = "Bronte",
                        Country = "UK",
                        BirthDate = new DateTime(1816, 04, 21)
                    },
                    new Author()
                    {
                        FirstName = "Jane",
                        LastName = "Austen",
                        Country = "UK",
                        BirthDate = new DateTime(1775, 12, 16)
                    },
                    new Author()
                    {
                        FirstName = "George",
                        LastName = "Eliot",
                        Country = "UK",
                        BirthDate = new DateTime(1819, 11, 22)
                    }
                });

                _dbContext.SaveChanges();
            }
        }

        private void GenerateUsers()
        {
            if (!_dbContext.Users.Any())
            {
                _dbContext.Users.AddRange(new List<User>()
                {
                    User.CreateUser(
                        "Max",
                        "Verstappen",
                        new DateTime(1997, 09, 30),
                        "Hasselt, Belgium",
                        "max@verstappen.com"),
                    User.CreateUser(
                        "Lewis",
                        "Hamilton",
                        new DateTime(1985, 07, 01),
                        "Stevenage, UK",
                        "lewis@hamilton.com"
                    ),
                    User.CreateUser(
                        "Sergio",
                        "Pérez",
                        new DateTime(1990, 01, 26),
                        "Guadalajara, Mexico",
                        "sergio@perez.com"),
                    User.CreateUser(
                        "Lando",
                        "Norris",
                        new DateTime(1999, 11, 13),
                        "Bristol, UK",
                        "lando@norris.com"
                    ),
                    User.CreateUser(
                        "Charles",
                        "Leclerc",
                        new DateTime(1997, 10, 16),
                        "Monte-Carlo, Monaco",
                        "charles@leclerc.com"
                    ),
                    User.CreateUser(
                        "Carlos",
                        "Sainz",
                        new DateTime(1994, 09, 01),
                        "Madrid, Spain",
                        "carlos@sainzjr.com"),

                    User.CreateUser(
                        "George",
                        "Russell",
                        new DateTime(1998, 02, 15),
                        "King's Lynn, UK",
                        "george@russell.com"
                    ),
                    User.CreateUser(
                        "Fernando",
                        "Alonso",
                        new DateTime(1981, 07, 29),
                        "Oviedo, Spain",
                        "fernando@alonso.com"
                    ),

                    User.CreateUser(
                        "Daniel",
                        "Ricciardo",
                        new DateTime(1989, 07, 01),
                        "Perth, Australia",
                        "dan@ricciardo.com"
                    ),
                });

                _dbContext.SaveChanges();
            }
        }

        private void GenerateBooks()
        {
            if (!_dbContext.Books.Any())
            {
                _dbContext.Books.AddRange(new List<Book>()
                {
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "George" &&
                            a.LastName == "Eliot"),
                        Name = "Middlemarch",
                        Year = 1871
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "Aldous" &&
                            a.LastName == "Huxley"),
                        Name = "Brave New World",
                        Year = 1932
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "Charlotte" &&
                            a.LastName == "Bronte"),
                        Name = "Jane Eyre",
                        Year = 1847
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "George" &&
                            a.LastName == "Eliot"),
                        Name = "The Mill on the Floss",
                        Year = 1860
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "Jane" &&
                            a.LastName == "Austen"),
                        Name = "Persuasion",
                        Year = 1818
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "Harper" &&
                            a.LastName == "Lee"),
                        Name = "To Kill a Mockingbird",
                        Year = 1960
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "George" &&
                            a.LastName == "Eliot"),
                        Name = "Silas Marner",
                        Year = 1861
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "Fyodor" &&
                            a.LastName == "Dostoevsky"),
                        Name = "Crime and Punishment",
                        Year = 1866
                    },
                    new Book()
                    {
                        Author = _dbContext.Authors.FirstOrDefault(a =>
                            a.FirstName == "Jane" &&
                            a.LastName == "Austen"),
                        Name = "Pride and Prejudice",
                        Year = 1813
                    }
                });

                _dbContext.SaveChanges();
            }
        }

        private void GenerateUserBooks()
        {
            var userBookData = new List<UserBook>()
            {
                new UserBook()
                {
                    UserId = _dbContext.Users.FirstOrDefault(u => u.LastName == "Hamilton").UserId,
                    BookId = _dbContext.Books.FirstOrDefault(b => b.Name.Contains("Mockingbird")).BookId
                },
                new UserBook()
                {
                    UserId = _dbContext.Users.FirstOrDefault(u => u.LastName.Contains("Alonso")).UserId,
                    BookId = _dbContext.Books.FirstOrDefault(b => b.Name.Contains("Persuasion")).BookId
                },
                new UserBook()
                {
                    UserId = _dbContext.Users.FirstOrDefault(u => u.LastName.Contains("Norris")).UserId,
                    BookId = _dbContext.Books.FirstOrDefault(b => b.Name.Contains("Middlemarch")).BookId
                },
                new UserBook()
                {
                    UserId = _dbContext.Users.FirstOrDefault(u => u.LastName.Contains("Hamilton")).UserId,
                    BookId = _dbContext.Books.FirstOrDefault(b => b.Name.Contains("New World")).BookId
                },
                new UserBook()
                {
                    UserId = _dbContext.Users.FirstOrDefault(u => u.LastName.Contains("Pérez")).UserId,
                    BookId = _dbContext.Books.FirstOrDefault(b => b.Name.Contains("Prejudice")).BookId
                }
            };


            if (!_dbContext.UserBooks.Any())
            {
                _dbContext.UserBooks.AddRange(userBookData);

                _dbContext.SaveChanges();
            }
        }
    }
}