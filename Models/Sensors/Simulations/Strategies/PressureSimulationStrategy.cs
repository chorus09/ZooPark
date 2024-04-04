
namespace Module18.Sensors.Simulations.Strategies; 
public class PressureSimulationStrategy : ISimulationStrategy {
    private readonly IPressureSensor _pressureSensor;

    public PressureSimulationStrategy(IPressureSensor pressureSensor) {
        _pressureSensor = pressureSensor;
    }
    public async Task StartSimulation() {
        var random = new Random();
        while (true) {
            double randomPressure = random.NextDouble() * 1000;
            PressureData newPressure = new PressureData(randomPressure);
            _pressureSensor.Update(newPressure);
            await Task.Delay(TimeSpan.FromSeconds(.2));
        }
    }
}
