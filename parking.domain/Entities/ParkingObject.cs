using parking.core.DomainObjects;

namespace parking.domain.Entities;

public class ParkingObject : Entity
{
    public string PlateVehicle { get; private set; }
    public Category Category { get; private set; }
    public DateTime DateTimeCreation { get; private set; }

    public DateTime DateTimeClose { get; private set; }

    public ParkingObject(string plateVehicle, DateTime dateTimeCreation, DateTime dateTimeClose, Category category)
    {
        PlateVehicle = plateVehicle;
        DateTimeCreation = dateTimeCreation;
        DateTimeClose = dateTimeClose;
        Category = category;

    }

    public void SetDatetimeClose() => DateTimeClose = DateTime.Now;

}