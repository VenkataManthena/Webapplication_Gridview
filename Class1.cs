using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication14
{
    public class StudentDatabase

    {

        public static List<Student> StudentList()
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student()
                {
                    FirstName ="Abraham",LastName="Lincoln",Gender="Male",University="MIT",
               },
                new Student()
                {
                    FirstName ="Thomas",LastName="Edison",Gender="Male",University="SU",
                },
               new Student()
               {
                    FirstName ="Rachel",LastName="Carlson",Gender="Female",University="CMU",
               },
                new Student()
               {
                    FirstName ="Marie",LastName="Curie",Gender="Female",University="HU",
               },
                new Student()
               {
                    FirstName ="Thomas",LastName="David",Gender="Male",University="MIT",
               },
                new Student()
               {
                    FirstName ="Robin",LastName="Peterson",Gender="Male",University="SU",
               },

            };

            return studentsList;
        }

        public static List<string> StatesList()
        {
            return new List<string>
            {
                 "Alabama",
               "Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawai","Idaho"

            };
        }

        public class Student
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Gender { get; set; }

            public string Major { get; set; }

            public string University { get; set; }
        }
    }
}