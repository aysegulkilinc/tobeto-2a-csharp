

namespace Business.Dtos.Car;

public class CarListItemDto // Dto: Data Transfer Object
{
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int ModelId { get; set; }


    public bool CarState { get; set; }
    public double Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }

    public ModelListItemDto? Model { get; set; } = null;
}