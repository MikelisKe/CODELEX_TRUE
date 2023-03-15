namespace Hierarchy
{
    public class Emplyee: Person
    {
        private string _jobtitle { get; set; }
        public Emplyee(string firstName, string lastName, string adress, int id) : base(firstName, lastName, adress, id)
        {
            
        }

        public string GetJob(string job)
        {
            return _jobtitle = job;
        }
        public override string DisplayPerson()
        {
            return ($"{FirstName} {LastName}, lives in {Adress} ID: {Id}, job: {_jobtitle}");
        }
    }
}