using System;
using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.model;

namespace nothinbutdotnetstore.tasks.stubs
{
    public class StubCartTasks : CartTasks
    {
        public void add(Product product)
        {
             
        }

        public IEnumerable<Product> get_all_products()
        {
            return Enumerable.Range(1, 3).Select(x => new Product() { name = x.ToString(" Product in shopping cart 0 ") });

        }
    }
}