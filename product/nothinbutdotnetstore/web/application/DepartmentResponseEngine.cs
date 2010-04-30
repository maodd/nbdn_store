using System.Web;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class DepartmentResponseEngine : ResponseEngine
    {
        public void display<ViewModel>(ViewModel view_model)
        {
            HttpContext.Current.Items.Add("main_departments", view_model);
            HttpContext.Current.Server.Transfer("DepartmentBrowser.aspx", true);
        }
    }
}