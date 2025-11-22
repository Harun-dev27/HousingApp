using HousingApp.Domain.Shared;

namespace HousingApp.Domain.Entity;

public class LandLord: BaseEntity
{
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public Email Email { get; set; } // constraints should be followed
    public string PhoneNumber { get; set; }
    public string Country { get; set; }
    public string County { get; set; }
   
    //Nullable properties have to be a the end of the constructor(marked by ?) i.e. public string? facebook
    public LandLord(string firstName, string lastName, string email, string phoneNumber, string country, string county)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Country = country;
        County = county;
    }
}


