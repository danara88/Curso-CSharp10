using ControlInversionContainer.Services;

namespace ControlInversionContainer.Controllers
{
    public class ImageController
	{
		private readonly IStorageService _storageService;
		public ImageController(IStorageService storageService)
		{
			_storageService = storageService;
		}

		public void SaveImage()
		{
			this._storageService.Save();
		}

		public void DeleteImage()
		{
			this._storageService.Delete();
		}

		public void UpdateImage()
		{
			this._storageService.Update();
		}
	}
}

