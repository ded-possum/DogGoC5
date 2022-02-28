using DogGoC5.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGoC5.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        Owner GetOwnerByEmail(string email);
        void AddOwner(Owner owner);
        void UpdateOwner(Owner owner);
        void DeleteOwner(int ownerId);







    }
}