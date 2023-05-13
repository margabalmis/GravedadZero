using Gravedad_Zero.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravedad_Zero.services
{
    class NewsRepository : IFirestoreRepository<New>
    {
        private readonly string CollectionName = "News";
        private readonly FirestoreRepository firestoreRepository;


        public NewsRepository()
        {
            firestoreRepository = new FirestoreRepository(CollectionName);
        }

        public New Get(New record)
        {
            return firestoreRepository.Get(record);
        }
    }
}
