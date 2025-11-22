using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Entity;

public  class HouseHold : BaseEntity
{
    public string Country { get; set; }
    public string County { get; set; }
    public string SubCounty { get; set; }
    public string Town { get; set; }
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public string CareTakerName { get; set; }

    public string CareTakerPhoneNumber { get; set; }

    //Nullable properties have to be a the end of the constructor(marked by ?) i.e. public string? facebook


    public HouseHold (string country, string county, string subCounty, string town, string location, string phoneNumber, string careTakerName, string careTakerPhoneNumber)
    {
        Country = country;
        County = county;
        SubCounty = subCounty;
        Town = town;
        Location = location;
        PhoneNumber = phoneNumber;
        CareTakerName = careTakerName;
        CareTakerPhoneNumber = careTakerPhoneNumber;

    }
    //public override void Validate()
    //{
    //    // Implement validation logic here
        
    //}
}
