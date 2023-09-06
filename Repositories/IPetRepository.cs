using l10_assignment.Models;

namespace l10_assignment.Repositories;

public interface IPetRepository {
    IEnumerable<Pet> GetPets();
    Pet? GetPetById(int petId);
    Pet CreatePet(Pet newPet);
    Pet? UpdatePet(Pet newPet);
    void DeletePetById(int petId);
}
