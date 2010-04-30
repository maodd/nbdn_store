using System.Collections.Generic;
using nothinbutdotnetstore.model;

namespace nothinbutdotnetstore.tasks
{
    public interface CartTasks
    {
        void add(Product product);
        IEnumerable<Product> get_all_products();
    }
}