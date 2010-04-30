using System.Web;
using nothinbutdotnetstore.web.core;
 

namespace nothinbutdotnetstore.web.application
{
    public class DefaultRequestFactory : RequestFactory
    {


        public Request create_a_request_from(HttpContext http_context)
        {
            return new DefaultRequest(new DefaultMapperRegistry(), http_context.Request.Form, http_context.Request.RawUrl);
        }
    }
}