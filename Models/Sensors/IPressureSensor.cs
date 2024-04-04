
namespace Module18.Sensors; 
public interface IPressureSensor : ISensor, ISensorEventDataChanged<PressureData> {
    PressureData Pressure { get; }
    void Update(PressureData pressure);
}
