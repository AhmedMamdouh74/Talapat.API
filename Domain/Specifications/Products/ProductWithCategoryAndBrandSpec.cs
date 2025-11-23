using Domain.Entities;

namespace Domain.Specifications.Products
{
    public class ProductWithCategoryAndBrandSpec : BaseSpecification<Product>
    {
        public ProductWithCategoryAndBrandSpec()
        {
            AddIncludes();

        }

       

        public ProductWithCategoryAndBrandSpec(int id) : base(p => p.Id == id)
        {
            AddIncludes();
        }
        private void AddIncludes()
        {
            Includes.Add(p => p.Brand);
            Includes.Add(p => p.Category);
        }
    }
}
