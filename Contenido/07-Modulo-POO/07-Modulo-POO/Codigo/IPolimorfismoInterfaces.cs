namespace _07_Modulo_POO.Codigo
{
    public static class IPolimorfismoInterfaces
	{
		public static void CodigoDelCurso()
		{
            var productA = new ProductA();

            var productB = new ProductB();

            GetProductDetail(productA);

            GetProductDetail(productB);
		}

		public static IProduct GetProductDetail(IProduct product)
		{
			return product;
		}
	}

	public interface IProduct
	{
		public void GetProduct();

		public void GetProducts();

		public void GetProductById();
	}

    /// <summary>
    /// Product A
    /// </summary>
    public class ProductA : IProduct
    {
        public void GetProduct()
        {
            throw new NotImplementedException();
        }

        public void GetProductById()
        {
            throw new NotImplementedException();
        }

        public void GetProducts()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Product B
    /// </summary>
    public class ProductB : IProduct
    {
        public void GetProduct()
        {
            throw new NotImplementedException();
        }

        public void GetProductById()
        {
            throw new NotImplementedException();
        }

        public void GetProducts()
        {
            throw new NotImplementedException();
        }
    }


}

