using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UEditor.ActionHandlers;

namespace UEditor
{
    public class UEditorHandler : IHttpHandler
    {

        public bool IsReusable
        {
            get { return true; }
        }

        private Configuration configration;

        public void ProcessRequest(HttpContext context)
        {
            if (configration == null)
            {
                configration = Configuration.GetDefault();
                Configure(configration);
            }

            ActionHandler action = null;
            switch (context.Request["action"])
            {
                case "config":
                    action = new ConfigHandler(context);
                    break;
                case "uploadimage":
                    action = new UploadHandler(context, new UploadConfig()
                    {
                        AllowExtensions = configration.ImageAllowFiles,
                        PathFormat = configration.ImagePathFormat,
                        SizeLimit = configration.ImageMaxSize,
                        UploadFieldName = configration.ImageFieldName,
                        SaveDirectory = configration.ImageSaveDirectory
                    });
                    break;
                case "uploadscrawl":
                    action = new UploadHandler(context, new UploadConfig()
                    {
                        AllowExtensions = new string[] { ".png" },
                        PathFormat = configration.ScrawlPathFormat,
                        SizeLimit = (int)configration.ScrawlMaxSize,
                        UploadFieldName = configration.ScrawlFieldName,
                        Base64 = true,
                        Base64Filename = "scrawl.png",
                        SaveDirectory = configration.ScrawlSaveDirectory
                    });
                    break;
                case "uploadvideo":
                    action = new UploadHandler(context, new UploadConfig()
                    {
                        AllowExtensions = configration.VideoAllowFiles,
                        PathFormat = configration.VideoPathFormat,
                        SizeLimit = (int)configration.VideoMaxSize,
                        UploadFieldName = configration.VideoFieldName,
                        SaveDirectory = configration.VideoSaveDirectory
                    });
                    break;
                case "uploadfile":
                    action = new UploadHandler(context, new UploadConfig()
                    {
                        AllowExtensions = configration.FileAllowFiles,
                        PathFormat = configration.FilePathFormat,
                        SizeLimit = (int)configration.FileMaxSize,
                        UploadFieldName = configration.FileFieldName,
                        SaveDirectory = configration.FileSaveDirectory
                    });
                    break;
                case "listimage":
                    action = new ListFileManager(context, configration.ImageManagerListPath, configration.ImageManagerAllowFiles);
                    break;
                case "listfile":
                    action = new ListFileManager(context, configration.FileManagerListPath, configration.FileManagerAllowFiles);
                    break;
                case "catchimage":
                    action = new CrawlerHandler(context);
                    break;
                default:
                    action = new NotSupportedHandler(context);
                    break;
            }
            action.Configuration = configration;
            action.Process();

        }

        protected virtual void Configure(Configuration settings)
        {

        }
    }
}
