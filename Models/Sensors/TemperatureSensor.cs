
namespace Module18.Sensors; 
public class TemperatureSensor : ITemperatureSensor {
    public TemperatureData Temperature { get; private set; }
    public string Name { get; private set; }
    public event EventHandler<TemperatureData>? SensorDataChanged;

    public TemperatureSensor(string name, TemperatureData temperature) {
        Temperature = temperature;
        Name = name;
    }
    public string GetData() => $"{Name} - {Temperature.Value}";
    public override string ToString() => Name;
    public void Update(TemperatureData temperature) {
        Temperature = temperature;
        SensorDataChanged?.Invoke(this, Temperature);
    }
}
