using System;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class PayloadKeys
    {
        public static class department
        {
            public static readonly PayloadKey<string> name = new PayloadKey<string>("name");
            public static readonly PayloadKey<DateTime> active_in_store_since = new PayloadKey<DateTime>("active_in_store_since");
            public static readonly PayloadKey<bool> is_active = new PayloadKey<bool>("is_active");
        }

        public static class product
        {
            public static readonly PayloadKey<string> name = new PayloadKey<string>("name");
          
        }
    }
}