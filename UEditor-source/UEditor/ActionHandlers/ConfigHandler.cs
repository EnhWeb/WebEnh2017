using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UEditor.ActionHandlers
{

    internal class ConfigHandler : ActionHandler
    {
        public ConfigHandler(HttpContext context) : base(context) { }

        public override void Process()
        {
            WriteJson(Configuration);
        }
    }
}