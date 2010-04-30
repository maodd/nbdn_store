using System;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class AddProductToCart : ApplicationCommand
    {
        CartTasks cart_tasks;
        readonly ResponseEngine response_engine;

        public AddProductToCart()
            : this(new StubCartTasks(), new CartEngine())
        {
            
        }

        public AddProductToCart(CartTasks cartTasks, ResponseEngine response_engine)
        {
            cart_tasks = cartTasks;
            this.response_engine = response_engine;
        }

        public void process(Request request)
        {
            cart_tasks.add(request.map<Product>());
            response_engine.display(cart_tasks.get_all_products()); ;
        }
    }
}