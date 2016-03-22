using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace IsolatedStorageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);

            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs");
            userWriter.Close();
        }
    }
}
