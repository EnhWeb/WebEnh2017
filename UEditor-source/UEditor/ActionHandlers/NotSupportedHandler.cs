using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UEditor.ActionHandlers
{

    internal class NotSupportedHandler : ActionHandler
    {
        public NotSupportedHandler(HttpContext context)
            : base(context)
        {
        }

        public override void Process()
        {
            WriteJson(new
            {
                state = "action 参数为空或者 action 不被支持。"
            });
        }
    }
}