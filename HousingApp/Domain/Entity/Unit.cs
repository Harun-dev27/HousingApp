namespace HousingApp.Domain.Entity
{
    public class Unit: BaseEntity
    {

        // One apartment can have multiple units
        // We have to define the  navigation prperty of the  one side together with its primary key (which becomes the FK)in the many class
        // Units.Apartment (For querying the apartment of a unit) 
        public string UnitName { get; set; }

        //One Unit belongs to one Apartment
        public Guid ApartmentId { get; set; } // Foreign key to Apartments
        public Apartment Apartment { get; set; } // Navigation property  // many units belong to one apartment  

        // One Unit belongs to one UnitType
        public Guid UnitTypeId { get; set; } // Foreign key to UnitTypes
        public UnitType UnitType { get; set; } // Navigation property // many units belong to one unit type
        
        public string UnitNumber { get; set; }
        public decimal RentAmount { get; set; }
        public bool IsOccupied { get; set; }
        public bool InBuiltWardrobe { get; set; }
        public bool InBuiltWashroom { get; set; }
        public decimal? SquareMetres { get; set; }

        public Unit() // Parameterless constructor for EF Core
        {
        }


        public Unit(string unitName, int apartmentId, string unitNumber, string unitTypeId, decimal rentAmount, Boolean isOccupied, Boolean inBuiltWardrobe, Boolean inBuiltWashroom, decimal? squareMetres)
        {
            UnitName = unitName;
            ApartmentId = apartmentId;
            UnitNumber = unitNumber;
            UnitTypeId = unitTypeId;
            RentAmount = rentAmount;
            IsOccupied = isOccupied;
            InBuiltWardrobe = inBuiltWardrobe;
            InBuiltWashroom = inBuiltWashroom;
            SquareMetres = squareMetres;
        }
    }
}
