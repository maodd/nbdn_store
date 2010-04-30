using System;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.web.application.mappers;
s


namespace nothinbutdotnetstore.web.application
{
    public class DefaultMapperRegistry : MapperRegistry
    {
      

        public Mapper<Input, Output> get_mapper_for<Input, Output>()
        {

            if (typeof(Output) == typeof(Department)) return (Mapper<Input, Output>)new DepartmentMapper();
            if (typeof(Output) == typeof(Product)) return (Mapper<Input, Output>)new ProductMapper();
            return null;
        }
    }
}