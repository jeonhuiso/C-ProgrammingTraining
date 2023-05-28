﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace week10_3
{
    public class Person
    {
        public Person(string fName , string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public string firstName;
        public string lastName;
    }
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for(int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;
        int position = -1;
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John","Smith"),
                new Person("John", "Smith"),
                new Person("John", "Smith")
            };
            People peopleList = new People(peopleArray);
            foreach(Person p in peopleList)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }

        }
    }
}
