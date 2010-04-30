using System.Collections.Specialized;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.model;

namespace nothinbutdotnetstore.web.application.mappers
{
    public class ProductMapper : Mapper<NameValueCollection, Product>
    {
        public Product map(NameValueCollection input)
        {
            return new Product
            {
                name = PayloadKeys.product.name.map_from(input) 
            };
        }

    }
}