using API.Model;

namespace API.Data
{
    public class DbInitializer
    {
        StoreContext context;
        public DbInitializer(StoreContext context)
        {
            this.context = context;
        }

        public void Initialize()
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Mo"
                },
                 new Product
                {
                    Name = "Charlotte"
                },
                  new Product
                {
                    Name = "阿寶"
                }

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}