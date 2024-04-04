
namespace Module18.Animals; 
public interface IAnimalFactory {
    Animal CreateAnimal(int id, string name, int age, double weight, double health, string status, Type animalType);
}
