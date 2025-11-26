using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Entity;
public class Apartment: BaseEntity 
{
    // One apartment can have multiple units
    // Many student many courses (define navigation properties on both sides) Place Icollection on both sides 
    // Entity framework(ORM) will create a junction table to represent the many to many relationship

    public string ApartmentName { get; set; }
    public string Address { get; set; }
    public string Street { get; set; }
    public string Location { get; set; }

    //One apartment can have multiple units
    public ICollection<Unit> Units { get; set; } = new List<Unit>(); // One apartment can have multiple units
    
    public bool IsVacant { get; set; }
    public bool ParkingAvailable { get; set; }
    public bool WaterAvailable { get; set; }
    public bool WifiAvailable { get; set; }
    public bool PetsAllowed { get; set; }

    public Apartment() // Parameterless constructor for EF Core
    {
    }

    public Apartment(string apartmentName, string address, string street, string location,  bool isVacant, bool parkingAvailable, bool waterAvailable, bool wifiAvailable, bool petsAllowed)
    {
        ApartmentName = apartmentName;
        Address = address;
        Street = street;
        Location = location;
        IsVacant = isVacant;
        ParkingAvailable = parkingAvailable;
        WaterAvailable = waterAvailable;
        WifiAvailable = wifiAvailable;
        PetsAllowed = petsAllowed;
    }
 }
