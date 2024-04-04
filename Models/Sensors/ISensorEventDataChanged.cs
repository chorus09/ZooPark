
namespace Module18.Sensors; 
public interface ISensorEventDataChanged<T> {
    event EventHandler<T> SensorDataChanged;
}
