using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Entity;
public class Apartment
{
    public int ApartmentId { get; set; }
    public string ApartmentName { get; set; }
    public string Address { get; set; }
    public string Street { get; set; }
    public string Location { get; set; }
    public int NumberOfUnits { get; set; }
    public boolean IsVacant { get; set; }
    public Boolean ParkingAvailable { get; set; }
    public Boolean WaterAvailable { get; set; }
    public Boolean WifiAvailable { get; set; }
    public Boolean PetsAllowed { get; set; }


    public Apartment(string apartmentName, string address, string street, string location, int numberOfUnits, Boolean isVacant, Boolean parkingAvailable, Boolean waterAvailable, Boolean wifiAvailable, Boolean petsAllowed)
    {
        ApartmentName = apartmentName;
        Address = address;
        Street = street;
        Location = location;
        NumberOfUnits = numberOfUnits;
        IsVacant = isVacant;
        ParkingAvailable = parkingAvailable;
        WaterAvailable = waterAvailable;
        WifiAvailable = wifiAvailable;
        PetsAllowed = petsAllowed;
    }
 }
