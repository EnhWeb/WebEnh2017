using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace UEditor
{
    public class RouteUEditorHandler : UEditorHandler, IRouteHandler
    {
        private Action<Configuration> _configure = null;

        public RouteUEditorHandler(Action<Configuration> configure = null)
        {
            _configure = configure;
        }

        protected override void Configure(Configuration settings)
        {
            if (_configure != null)
            {
                _configure(settings);
            }
        }

        public System.Web.IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return this;
        }
    }
}
