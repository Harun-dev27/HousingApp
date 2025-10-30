namespace HousingApp.Domain.Entity
{
    public class Units
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int ApartmentId { get; set; } // Foreign key to Apartments
        public Apartment apartment { get; set; } // Navigation property  // many units belong to one apartment  
        public string UnitNumber { get; set; }
        public string UnitTypeId { get; set; } // Foreign key to UnitTypes
        public UnitType UnitType { get; set; } // Navigation property // many units belong to one unit type
        public decimal RentAmount { get; set; }
        public ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
        public ICollection<UnitType> UnitTypes { get; set; } = new List<UnitType>();
        public Boolean IsOccupied { get; set; }
        public Boolean InBuiltWardrobe { get; set; }
        public Boolean InBuiltWashroom { get; set; }
        public decimal? SquareMetres { get; set; }


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
