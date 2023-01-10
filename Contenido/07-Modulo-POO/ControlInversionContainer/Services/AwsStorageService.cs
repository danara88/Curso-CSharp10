namespace ControlInversionContainer.Services
{
    public class AwsStorageService : IStorageService
	{
        public bool Delete()
        {
            Console.WriteLine("AWS delete file");
            return true;
        }

        public string Save()
        {
            Console.WriteLine("AWS save file");
            return "AzureURL";
        }

        public bool Update()
        {
            Console.WriteLine("AWS update file");
            return true;
        }
    }
}

