namespace ControlInversionContainer.Services
{
    public interface IStorageService
	{
		public string Save();

		public bool Delete();

		public bool Update();

		// Implementación por defecto de interfaces
		public void Get()
		{
			Save();
		}
	}
}

