using HousingApp.Domain.Shared;
namespace HousingApp.Domain.Shared
{
    public abstract class BaseEntity //abstract can be inherited but sealed cannot be inherited
    {
        public int Id { get; set; } // all entities will have an Id property
    }
}
