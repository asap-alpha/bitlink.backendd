namespace Bitlink.User.Api;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }
//will be deleted later
   public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}