using Module18.Sensors;

namespace Module18.Animals; 
public interface IAnimalSensors {
    List<ISensor>? Sensors { get; }
    void AttachSensor<TSensor>(TSensor sensor) where TSensor : ISensor;
    void DetachSensor<TSensor>(TSensor sensor) where TSensor : ISensor;
}
