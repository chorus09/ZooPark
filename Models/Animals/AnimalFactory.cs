

namespace Module18.Animals;
public class AnimalFactory : IAnimalFactory {
    public Animal CreateAnimal(int id, string name, int age, double weight, double health, string status, Type animalType) {
        if (!typeof(Animal).IsAssignableFrom(animalType))
            throw new ArgumentException("Type is not a valid animal type");

        return (Animal)Activator.CreateInstance(animalType, id, name, age, weight, health, status)!;
    }
}
