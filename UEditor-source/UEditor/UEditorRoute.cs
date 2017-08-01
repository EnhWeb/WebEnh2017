using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace UEditor
{
    public class UEditorRoute : RouteBase
    {
        private Action<Configuration> _configure;
        private string _baseUrl = "/uditor";

        public UEditorRoute(string ueditBaseUrl = null, Action<Configuration> configure = null)
        {
            if (ueditBaseUrl != null)
            {
                ueditBaseUrl = ueditBaseUrl.Trim();
                if (!ueditBaseUrl.StartsWith("/"))
                {
                    throw new ArgumentException("Param[ueditBaseUrl] must start with character [/]", "ueditBaseUrl");
                }
                _baseUrl = ueditBaseUrl;
            }
            _configure = configure;
        }

        public override RouteData GetRouteData(System.Web.HttpContextBase httpContext)
        {

            if (httpContext.Request.Path.StartsWith(_baseUrl, StringComparison.OrdinalIgnoreCase))
            {
                return new RouteData(this, new RouteUEditorHandler(_configure));
            }
            else
            {
                return null;
            }
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            return null;
        }

    }
}
