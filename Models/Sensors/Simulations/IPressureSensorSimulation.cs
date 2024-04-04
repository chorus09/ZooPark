
namespace Module18.Sensors.Simulations; 
public interface IPressureSensorSimulation {
    Task StartSimulation(IPressureSensor pressureSensor);
}
