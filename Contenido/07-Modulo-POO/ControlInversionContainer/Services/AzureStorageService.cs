using System;
namespace ControlInversionContainer.Services
{
    public class AzureStorageService : IStorageService
    {
        public bool Delete()
        {
            Console.WriteLine("Azure delete file");
            return true;
        }

        public string Save()
        {
            Console.WriteLine("Azure save file");
            return "AzureURL";
        }

        public bool Update()
        {
            Console.WriteLine("Azure update file");
            return true;
        }
    }
}

