namespace WeatherStation.DataAccess.Entities;

public class WeatherStationEntity
{
    public Guid WeatherStationId { get; set; }
    public string Name { get; set; } = null!;
}