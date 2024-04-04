
namespace Module18.Sensors.Simulations.Strategies; 
public class TemperatureSimulationStrategy : ISimulationStrategy {
    private readonly ITemperatureSensor _temperatureSensor;

    public TemperatureSimulationStrategy(ITemperatureSensor temperatureSensor) {
        _temperatureSensor = temperatureSensor;
    }

    public async Task StartSimulation() {
        var random = new Random();
        while (true) {
            double randomTemperature = random.NextDouble() * 100;
            var newTemperature = new TemperatureData(randomTemperature);
            _temperatureSensor.Update(newTemperature);
            await Task.Delay(TimeSpan.FromSeconds(.2));
        }
    }
}
