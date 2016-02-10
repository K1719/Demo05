/* 
 * Copyright (C) PTM
 * 
 * This file is part of the Person Register project.
 * 
 * Created: 10.2.2016 
 * Authors: Juho Valtonen 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    /// <summary>
    /// This class holds person objects in a collection.
    /// </summary>
    class PersonRegister
    {
        /// <summary>
        /// Persons List stores person objects...
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor initializes a collection.
        /// </summary>
        public PersonRegister()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Adds a new person to collection.
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Returns a person to caller application.
        /// </summary>
        /// <param name="index">person index in collection</param>
        /// <returns>person object</returns>
        public Person GetPerson(int index)
        {
            /*
            index = 0 1 2
            persons = p1 p2 p3
            persons.Count = 3
            */
            if (index > persons.Count)
            {
                return persons.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
        public Person FindPerson(string socialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                // are sotus the same..?
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person; // person found with that sotu.
                }
            }
            return null; // person with that sotu was not found.
        }
        public void PrintData()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*                        *");
            Console.WriteLine("* My awesome collection: *");
            Console.WriteLine("*                        *");
            Console.WriteLine("**************************");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
