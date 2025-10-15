namespace HousingApp.Models
{
    public class Housing
    {
        //prop .... your tab key to generate the property
        public string FirstName { get; set; } // properties ...

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}"; // It is only a getter

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Town { get; set; }

        public decimal Rent { get; set; }

        //Nullable properties have to be a the end of the constructor(marked by ?) i.e. public string? facebook

        public Housing(string firstName, string lastName, string email, string phoneNumber, string city, string county, string town, decimal rent)
        {
            //  constructor
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            City = city;
            County = county;
            Town = town;
            Rent = rent;


        }

    }
}
