namespace MvcApp.ViewModel
{
    public class PersonModel
    {
        public PersonModel()
        {
        }
        public PersonModel(Salutation salutation, string firstName, string lastName)
        {
            Salutation = salutation;
            FirstName = firstName;
            LastName = lastName;
        }

        public long Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Salutation Salutation { get; set; }
    }
}