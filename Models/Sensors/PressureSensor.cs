
namespace Module18.Sensors; 
public class PressureSensor : IPressureSensor {
    public PressureData Pressure { get; private set; }
    public string Name { get; private set; }
    public event EventHandler<PressureData>? SensorDataChanged;

    public PressureSensor(string name, PressureData pressure) {
        Pressure = pressure;
        Name = name;
    }
    public string GetData() => $"{Name} - {Pressure.Value}";
    public override string ToString() => Name;
    public void Update(PressureData pressure) {
        Pressure = pressure;
        SensorDataChanged?.Invoke(this, Pressure);
    }
}
