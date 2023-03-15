namespace Hierarchy
{
    public class Student : Person
    {
        private double _gpa { get ; set; }
        public Student(string firstName, string lastName, string adress, int id) : base(firstName, lastName, adress, id)
        {

        }
        public double Ggpa(double gpa)
        {
            return _gpa = gpa;
        }

        public override string DisplayPerson()
        {
            return ($"{FirstName} {LastName}, lives in {Adress} ID: {Id}, gpa: {_gpa}");
        }
    }
}