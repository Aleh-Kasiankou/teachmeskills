using System;
using System.Collections.Generic;

namespace EFLibraryPersistence.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime ExpiredDate { get; set; }
        public IEnumerable<UserBook> UserBooks { get; set; }

        private User()
        {
        }

        public static User CreateUser(string firstName, string lastName, DateTime birthdate,
            string address, string email)
        {
            var user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                BirthDate = birthdate,
                Address = address,
            };

            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }
            user.Age = age;
            user.ExpiredDate = today.AddYears(1);
            return user;
        }
    }
}