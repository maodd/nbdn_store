using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class CartEngine : ResponseEngine
    {

        public void display<ViewModel>(ViewModel view_model)
        {
            HttpContext.Current.Items.Add("products", view_model);
            HttpContext.Current.Items.Add("products_count", ((IEnumerable<Product>)view_model).Count());
            HttpContext.Current.Server.Transfer("shoppingcart.aspx", true);
        }
    }
}