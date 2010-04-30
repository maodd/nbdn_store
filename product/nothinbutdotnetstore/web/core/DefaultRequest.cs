using System;
using System.Collections.Specialized;
using System.Web;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultRequest : Request
    {
        MapperRegistry mapper_registry;
        NameValueCollection request_data;
         

        public DefaultRequest(MapperRegistry mapper_registry, NameValueCollection request_data, string url)
        {
            this.mapper_registry = mapper_registry;
            this.request_data = request_data;
            this.url = url;
        }

        public InputModel map<InputModel>()
        {
            return mapper_registry.get_mapper_for<NameValueCollection, InputModel>().map(request_data);
        }

        public string url { get; private set; }
    }
}