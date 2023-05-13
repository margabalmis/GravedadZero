using Google.Cloud.Firestore;
using System;


namespace Gravedad_Zero.services
{
    public class FirestoreRepository
    {
        private readonly string CollectionName;
        public FirestoreDb firestoreDb;

        public FirestoreRepository(string CollectionName)
        {
            string filePath = "/Users/marga/OneDrive/Escritorio/GravedadZero/recursosProyecto/google-services";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIAL", filePath);
            firestoreDb = FirestoreDb.Create("gravedad-zero-f1b21");
            this.CollectionName = CollectionName;
           
        }
        public T Get<T>(T record) where T : FirebaseDocument
        {
            DocumentReference docRef = firestoreDb.Collection(CollectionName).Document(record.Id);
            DocumentSnapshot snapshot = docRef.GetSnapshotAsync().GetAwaiter().GetResult();
            if (snapshot.Exists)
            {
                T usr = snapshot.ConvertTo<T>();
                usr.Id = snapshot.Id;
                return usr;

            }
            else 
            {
                return null;
            }
        }
    }

}
