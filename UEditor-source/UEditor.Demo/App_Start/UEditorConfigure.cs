using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace UEditor.Demo
{
    public static class UEditorConfigure
    {
        public static void Demo1(UEditor.Configuration settings)
        {
            settings.ImageSaveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "upload/demo1/image/");
            settings.ImageUrlPrefix = "/upload/demo1/image/";
        }

        public static void Demo2(UEditor.Configuration settings)
        {
            settings.ImageSaveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "upload/demo2/image/");
            settings.ImageUrlPrefix = "/upload/demo2/image/";
        }
    }
}