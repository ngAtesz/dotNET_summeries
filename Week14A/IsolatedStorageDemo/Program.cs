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
            IsolatedStorageFileStream userStream;

            string userSettingsFileName = "UserSettings.set";
            string[] files = userStore.GetFileNames(userSettingsFileName);
            if (files.Length == 0)
            {
                userStream = new IsolatedStorageFileStream(userSettingsFileName, FileMode.Create, userStore);
                StreamWriter userWriter = new StreamWriter(userStream);
                userWriter.WriteLine("User Prefs");
                userWriter.Close();
                Console.WriteLine("{0} created.", userSettingsFileName);
            }
            else
            {
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStore);
                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine("IsolatedStorageFile content: {0}", contents);
            }
            
            Console.Read();
        }
    }
}
