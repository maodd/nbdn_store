using System.Collections.Generic;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class DefaultRawRequestHandler : RawRequestHandler
    {

         static IEnumerable<RequestCommand> command_dictionary =
            new RequestCommand[]
                {
                    new DefaultRequestCommand(x => x.url.Contains("ViewMainDepartments"), new ViewMainDepartments()),
                    new DefaultRequestCommand(x => x.url.Contains("ViewSubDepartmentsInDepartment"), new ViewSubDepartmentsInDepartment()),
                    new DefaultRequestCommand(x => x.url.Contains("ViewProductsInDepartment"), new ViewProductsInDepartment()),
                    new DefaultRequestCommand(x => x.url.Contains("AddProductToCart"), new AddProductToCart())
                };

        public DefaultRawRequestHandler()
            : base(new DefaultFrontController(new DefaultCommandRegistry(command_dictionary)), new DefaultRequestFactory())
        {
        }
        
    }
}