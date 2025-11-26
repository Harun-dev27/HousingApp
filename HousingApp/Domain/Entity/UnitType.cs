
namespace HousingApp.Domain.Entity;

public class UnitType: BaseEntity
{
    public string UnitTypeName { get; set; }
    public decimal Rent { get; set; }

    //One unit type can be used by many units
    public ICollection<Unit>Units { get; set; } = new List<Unit>(); // One unit type can be associated with multiple units
    
    public UnitType() // Parameterless constructor for EF Core
    {

    }
    public UnitType(string unitTypeName, decimal rent)
    {
        UnitTypeName = unitTypeName;
        Rent = rent;
    }
}
