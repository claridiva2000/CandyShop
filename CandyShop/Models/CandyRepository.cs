using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy { CandyId=1, 
                Name="Assorted Hard Candy", 
                Price=5.00M, 
                Description="Cupcake ipsum dolor sit amet. Lollipop pie marzipan wafer ",
                Category=_categoryRepository.GetallCategories.ToList()[0], 
                ImgUrl="https://cdn-tp2.mozu.com/15653-24061/cms/24061/files/a657b8a4-ddde-4d62-9d1a-a1a0220470bd?max=1024", 
                ImgThumbnailUrl="https://cdn-tp2.mozu.com/15653-24061/cms/24061/files/a657b8a4-ddde-4d62-9d1a-a1a0220470bd?max=150",
                IsInStock=true, 
                IsOnSale=true }, 

            new Candy { CandyId=2, 
                Name="Assorted Chocolate Candy", 
                Price=5.50M,
                Description="Cupcake ipsum dolor sit amet. Lollipop pie marzipan wafer ",
                Category=_categoryRepository.GetallCategories.ToList()[1], 
                ImgUrl="https://cdn.shopify.com/s/files/1/0150/8992/6198/products/7616-PRODUCT_02-500_500-1414533575343_0b2cc84d-8cc1-4ad4-aae6-6e9ea8e09837_1024x.png?v=1565185073",
                ImgThumbnailUrl="https://cdn.shopify.com/s/files/1/0150/8992/6198/products/7616-PRODUCT_02-500_500-1414533575343_0b2cc84d-8cc1-4ad4-aae6-6e9ea8e09837_150x.png?v=1565185073",
                IsInStock=true, IsOnSale=true}, 
            
            new Candy { CandyId=3, 
                Name="Assorted Sour Candy", 
                Price=5.95M, 
                Description="Cupcake ipsum dolor sit amet. Lollipop pie marzipan wafer ",
                Category=_categoryRepository.GetallCategories.ToList()[2], 
                ImgUrl="https://cdn.shopify.com/s/files/1/0150/8992/6198/products/2020-01-23-DCB-AF12401_1024x.jpg?v=1581629409",
                ImgThumbnailUrl="https://cdn.shopify.com/s/files/1/0150/8992/6198/products/2020-01-23-DCB-AF12401_150x.jpg?v=1581629409",
                IsInStock=true, 
                IsOnSale=true }
        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
