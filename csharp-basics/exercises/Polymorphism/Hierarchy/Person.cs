using System;

namespace Hierarchy
{
    public  class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Id { get; set; }

        public Person(string firstName, string lastName, string adress, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            Id = id;
        }
        public virtual string DisplayPerson()
        {
            return ($"{FirstName} {LastName}, lives in {Adress} ID: {Id}");
        }
    }
}