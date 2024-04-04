
namespace Module18.Animals;
public abstract class Animal :  IAnimalSensors {
    protected Animal(int id, string name, int age, double weight, double health, string status) {
        Id = id;
        Name = name;
        Age = age;
        Weight = weight;
        Health = health;
        Status = status;
        Sensors = [];
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Health { get; set; }
    public string Status { get; set; } = string.Empty;

    public List<ISensor>? Sensors { get; private set; }

    public void AttachSensor<TSensor>(TSensor sensor) where TSensor : ISensor {
        Sensors?.Add(sensor);
    }

    public void DetachSensor<TSensor>(TSensor sensor) where TSensor : ISensor {
        Sensors?.Remove(sensor);
    }
}
