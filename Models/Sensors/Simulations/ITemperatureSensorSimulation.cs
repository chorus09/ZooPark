
namespace Module18.Sensors.Simulations; 
public interface ITemperatureSensorSimulation {
    Task StartSimulation(ITemperatureSensor temperatureSensor);
}
