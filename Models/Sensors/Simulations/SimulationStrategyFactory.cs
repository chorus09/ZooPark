using Module18.Sensors.Factory;
using Module18.Sensors.Simulations.Strategies;

namespace Module18.Sensors.Simulations; 
public class SimulationStrategyFactory {
    private readonly ISensorFactory _sensorFactory;

    public SimulationStrategyFactory(ISensorFactory sensorFactory) {
        _sensorFactory = sensorFactory;
    }

    public ISimulationStrategy CreateSimulationStrategy(ISensor sensor) {
        if (sensor is ITemperatureSensor) {
            return new TemperatureSimulationStrategy((ITemperatureSensor)sensor);
        } else if (sensor is IPressureSensor) {
            return new PressureSimulationStrategy((IPressureSensor)sensor);
        } else {
            throw new ArgumentException("Unsupported sensor type");
        }
    }
}
