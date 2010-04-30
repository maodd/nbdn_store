 using System;
 using System.Collections.Generic;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.harnesses.mbunit;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.model;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;
 using developwithpassion.bdd.mocking.rhino;

namespace nothinbutdotnetstore.tests.web
 {   
     public class AddProductToCartSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<ApplicationCommand,
                                             AddProductToCart>
         {
        
         }

         [Concern(typeof(AddProductToCart))]
         public class when_adding_a_product_to_cart : concern
         {
             context c = () =>
             {
                 request = an<Request>();
                 product_list = new List<Product>();
                 response_engine = the_dependency<ResponseEngine>();
                 product = new Product();
                 cart_tasks = the_dependency<CartTasks>();
                 add_result = true;

                 request.Stub(x => x.map<Product>()).Return(product);
             };

             because b = () =>
             {
                sut.process(request);
             };

             it should_add_product_into_cart = () =>
             {
                 cart_tasks.received(x => x.add(product));

             };
        
             it should_display_product_list_in_cart_ = () =>
             {
                 
            
            
             };

             static Request request;
             static Product product;
             static IEnumerable<Product> product_list;
             static ResponseEngine response_engine;
             static CartTasks cart_tasks;
             static bool add_result;
         }
     }


 }
