using System;

namespace ClassPractice {
    class Program{
        
        static void Main(string[] args)
        {
            Person perOne = new Person();
            
            perOne.setFirstName("Muhammad");
            perOne.setLastName("fahim");

            Console.WriteLine(perOne.getFirstName() + " " + perOne.getLastName());
        }

    }

    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public Person(){

        }
        public Person(string firstName,string lastName, DateTime birthDate, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.country = country;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }


        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }


    }

   
}