 using System;
 using System.Collections.Generic;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.harnesses.mbunit;
 using developwithpassion.bdd.mocking.rhino;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.model;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
 {   
     public class ViewProductsInDepartmentSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<ApplicationCommand,
                                             ViewProductsInDepartment>
         {
        
         }

         [Concern(typeof(ViewProductsInDepartment))]
         public class when_observation_name : concern
         {
             context c = () =>
             {
                 request = an<Request>();
                 product_list = new List<Product>();
                 response_engine = the_dependency<ResponseEngine>();
                 department = new Department();
                 catalog_tasks = the_dependency<CatalogTasks>();


                 request.Stub(x => x.map<Department>()).Return(department);
                 catalog_tasks.Stub(x => x.get_all_products_in_department(department)).Return(product_list);
             };

             because b = () =>
             {
                 sut.process(request);
             };

        
             it should_display_all_products_in_a_department = () =>
             {

                 response_engine.received(x => x.display(product_list));
            
             };

             static IEnumerable<Product> results;
             static IEnumerable<Product> product_list;
             static Request request;
             static Department department;
             static CatalogTasks catalog_tasks;
             static ResponseEngine response_engine;
         }
     }




 }
