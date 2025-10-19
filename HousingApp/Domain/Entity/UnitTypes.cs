using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Entity;

public class UnitTypes
{
    public string UnitTypeId { get; set; }
    public string UnitTypeName { get; set; }
    public decimal Rent { get; set; }
    public UnitTypes(string unitTypeId, string unitTypeName, decimal Rent)
    {
        UnitTypeId = unitTypeId;
        UnitTypeName = unitTypeName;
        this.Rent = Rent;
    }
}
