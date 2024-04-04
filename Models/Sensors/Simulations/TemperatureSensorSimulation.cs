
namespace Module18.Sensors.Simulations; 
public class TemperatureSensorSimulation : ITemperatureSensorSimulation {
    private readonly SimulationStrategyFactory _strategyFactory;

    public TemperatureSensorSimulation(SimulationStrategyFactory strategyFactory) {
        _strategyFactory = strategyFactory;
    }

    public async Task StartSimulation(ITemperatureSensor temperatureSensor) {
        var strategy = _strategyFactory.CreateSimulationStrategy(temperatureSensor);
        await strategy.StartSimulation();
    }
}
