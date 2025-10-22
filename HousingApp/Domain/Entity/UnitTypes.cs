using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Entity;

public class UnitTypes
{
    public string UnitTypeId { get; set; }
    public string UnitTypeName { get; set; }
    public ICollection<Units> { get; set; } = new List<Units>();
    public ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
public UnitTypes(string unitTypeId, string unitTypeName, decimal Rent)
    {
        UnitTypeId = unitTypeId;
        UnitTypeName = unitTypeName;
    }
}
