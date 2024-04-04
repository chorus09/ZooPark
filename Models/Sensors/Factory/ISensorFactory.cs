
namespace Module18.Sensors.Factory; 
public interface ISensorFactory {
    ITemperatureSensor CreateTemperatureSensor(string sensorName, TemperatureData initialTemperature);
    IPressureSensor CreatePressureSensor(string sensorName, PressureData initialPressure);
}
