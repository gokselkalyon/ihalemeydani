using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Firebase
{
    public class FirebaseStorageHelper
    {
        /*
         
           Firebase için gmail :
           ihalemeydan@gmail.com
           Ihale123+-
             
         */


        FirebaseStorage firebaseStorage;
        public FirebaseStorageHelper(string path)
        {
            firebaseStorage = new FirebaseStorage(path);
        }

        public async Task<string> UploadFile(Stream fileStream, string fileName)
        {
            //XamarinMonkeys Storage İçindeki klasör adıdır yoksa klasör kendisi ekler. 
            //XamarinMonkeys file adıdır.Değiştirebiliriz

            var imageUrl = await firebaseStorage
                .Child("XamarinMonkeys")
                .Child(fileName)
                .PutAsync(fileStream);
            return imageUrl;
        }
        public async Task<string> GetFile(string fileName)
        {
            return await firebaseStorage
                .Child("XamarinMonkeys")
                .Child(fileName)
                .GetDownloadUrlAsync();
        }
        public async Task DeleteFile(string fileName)
        {
            await firebaseStorage
                 .Child("XamarinMonkeys")
                 .Child(fileName)
                 .DeleteAsync();

        }
    }
}
