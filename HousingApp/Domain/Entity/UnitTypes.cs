using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Entity;

public class UnitTypes
{
    public string UnitTypeId { get; set; }
    public string UnitTypeName { get; set; }
    public ICollection<Unit>Units { get; set; } = new List<Unit>(); // One unit type can be associated with multiple units
    public ICollection<ApartmentUnitType> ApartmentUnitTypes { get; set; } = new List<ApartmentUnitType>(); // One unit type can be associated with multiple apartment-unit type relationships
    public UnitTypes(string unitTypeId, string unitTypeName, decimal Rent)
    {
        UnitTypeId = unitTypeId;
        UnitTypeName = unitTypeName;
    }
}
