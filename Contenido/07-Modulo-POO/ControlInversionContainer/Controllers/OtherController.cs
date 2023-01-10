namespace ControlInversionContainer.Controllers
{
    public class OtherController
	{
		private readonly ImageController _imageController;

		public OtherController(ImageController imageController)
		{
			_imageController = imageController;
		}

		public void SaveMyPdf()
		{
			_imageController.SaveImage();
		}
	}
}

