
namespace Module18.Sensors.Factory; 
public class SensorFactory : ISensorFactory {
    public IPressureSensor CreatePressureSensor(string sensorName, PressureData initialPressure) =>
        new PressureSensor(sensorName, initialPressure);

    public ITemperatureSensor CreateTemperatureSensor(string sensorName, TemperatureData initialTemperature) =>
        new TemperatureSensor(sensorName, initialTemperature);
}
