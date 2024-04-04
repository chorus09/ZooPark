
namespace Module18.Sensors.Simulations; 
public class PressureSensorSimulation : IPressureSensorSimulation {
    private readonly SimulationStrategyFactory _strategyFactory;

    public PressureSensorSimulation(SimulationStrategyFactory strategyFactory) {
        _strategyFactory = strategyFactory;
    }

    public async Task StartSimulation(IPressureSensor pressureSensor) {
        var strategy = _strategyFactory.CreateSimulationStrategy(pressureSensor);
        await strategy.StartSimulation();
    }
}
