using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using WingtipToys.Models;

namespace WingtipToys
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // initialize the product database
            Database.SetInitializer(new ProductDatabaseInitializer());

            /*
            As shown in the above code, when the application starts, the application specifies the initializer
            that will run during the first time the data is accessed. The two additional namespaces are
            required to access the Database object and the ProductDatabaseInitializer object.
            */
        }
    }
}
 