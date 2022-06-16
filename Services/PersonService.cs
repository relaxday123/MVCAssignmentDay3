using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using b1.Models;
using CsvHelper;

namespace b1.Services
{
    public class PersonService : IPersonService
    {
        private static List<Person> _people = new List<Person>
        {
            new Person
            {
                FirstName = "Vu Hoang Truong",
                LastName = "Giang",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 12, 26),
                PhoneNumber = "",
                BirthPlace = "Hai Phong",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Pham Duc",
                LastName = "Hai",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 12, 26),
                PhoneNumber = "",
                BirthPlace = "",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Duong Di",
                LastName = "An",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 6, 28),
                PhoneNumber = "",
                BirthPlace = "",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Dang Tuan",
                LastName = "Anh",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 12, 26),
                PhoneNumber = "",
                BirthPlace = "",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Nguyen Hoang",
                LastName = "Anh",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 11, 25),
                PhoneNumber = "",
                BirthPlace = "Hai Phong",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Ngo Huu",
                LastName = "Toan",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 11, 25),
                PhoneNumber = "",
                BirthPlace = "Hai Phong",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "miss",
                LastName = "A",
                Gender = "Female",
                DateOfBirth = new DateTime(2001, 11, 25),
                PhoneNumber = "",
                BirthPlace = "Hai Phong",
                IsGraduated = false
            },
        };

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person Create(Person member)
        {
            _people.Add(member);
            return member;
        }

        public Person GetOne(int index)
        {
            return (index >= 0 && index < _people.Count) ? _people[index] : null;
        }

        public Person Update(Person member, int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                _people[index] = member;
                return member;
            }
            else
                return null;
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < _people.Count)
                _people.RemoveAt(index);
        }
    }
}