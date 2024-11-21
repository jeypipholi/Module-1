namespace Generics_Activity
{
    public class Product
    {
        public int ProductId
        {
            get;
            set;
        }
       
        public string ProductName
        {
            get;
            set;
        }
        public override string ToString()
        {
            return $"Product Id {ProductId} Product Name: {ProductName}";
        }

    }
}
