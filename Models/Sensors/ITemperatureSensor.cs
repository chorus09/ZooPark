
namespace Module18.Sensors;
public interface ITemperatureSensor : ISensor, ISensorEventDataChanged<TemperatureData> {
    TemperatureData Temperature { get; }
    void Update(TemperatureData temperature);
}
