using Gravedad_Zero.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravedad_Zero.services
{
    class UsersRepository : IFirestoreRepository<User>
    {
        private readonly string CollectionName = "Users";
        private readonly FirestoreRepository firestoreRepository;


        public UsersRepository()
        {
            firestoreRepository = new FirestoreRepository(CollectionName);
        }

        public User Get(User record)
        {
            return firestoreRepository.Get(record);
        }
    }
}
