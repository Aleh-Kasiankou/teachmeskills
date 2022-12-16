using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace adoNet
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var sc = new SqlConnection("Server=localhost; Database=SqlPracticeDB; Integrated Security=SSPI");
            sc.Open();
            var command =
                new SqlCommand(
                    "SELECT DISTINCT Persons.Id, Persons.Name, Persons.Age, Country, City " +
                    "FROM Persons \n    INNER JOIN PersonsStudySubjects PSS on Persons.Id = PSS.StudentId\n    " +
                    "INNER JOIN Addresses A on A.Id = Persons.AddressId;",
                    sc);
            var sqlReader = await command.ExecuteReaderAsync();

            var people = new List<Person>();
            while (await sqlReader.ReadAsync())
            {
                var name = await sqlReader.IsDBNullAsync("Name")
                    ? null
                    : await sqlReader.GetFieldValueAsync<string>("Name");
                
                var age = await sqlReader.IsDBNullAsync("Age")
                    ? (int?)null
                    : await sqlReader.GetFieldValueAsync<int>("Age");
                
                var country = await sqlReader.IsDBNullAsync("Country")
                    ? null
                    :await sqlReader.GetFieldValueAsync<string>("Country");
                
                var city = await sqlReader.IsDBNullAsync("City")
                    ? null
                    : await sqlReader.GetFieldValueAsync<string>("City");
                
                people.Add(new Person() { Name = name, Age = age, Country = country, City = city });
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            sc.Close();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"{Name} | {Age} | {Country} | {City}";
        }
    }
}