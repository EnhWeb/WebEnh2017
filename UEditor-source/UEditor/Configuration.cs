using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UEditor
{
    public class Configuration
    {
        #region  上传图片配置项

        /// <summary>
        /// 执行上传图片的action名称
        /// </summary>
        [JsonProperty("imageActionName")]
        public string ImageActionName { get; set; }
        /// <summary>
        /// 提交的图片表单名称
        /// </summary>
        [JsonProperty("imageFieldName")]
        public string ImageFieldName { set; get; }
        /// <summary>
        /// 上传大小限制，单位B
        /// </summary>
        [JsonProperty("imageMaxSize")]
        public int ImageMaxSize { set; get; }
        /// <summary>
        /// 上传图片格式显示
        /// </summary>
        [JsonProperty("imageAllowFiles")]
        public string[] ImageAllowFiles { set; get; }
        /// <summary>
        /// 是否压缩图片,默认是true
        /// </summary>
        [JsonProperty("imageCompressEnable")]
        public bool ImageCompressEnable { get; set; }
        /// <summary>
        ///图片压缩最长边限制 
        /// </summary>
        [JsonProperty("imageCompressBorder")]
        public int ImageCompressBorder { get; set; }
        /// <summary>
        /// 插入的图片浮动方式
        /// </summary>
        [JsonProperty("imageInsertAlign")]
        public string ImageInsertAlign { get; set; }
        /// <summary>
        /// 图片访问路径前缀
        /// </summary>
        [JsonProperty("imageUrlPrefix")]
        public string ImageUrlPrefix { get; set; }
        /// <summary>
        /// 上传保存路径,可以自定义保存路径和文件名格式
        /// {filename} 会替换成原文件名,配置这项需要注意中文乱码问题
        /// {rand:6} 会替换成随机数,后面的数字是随机数的位数
        /// {time} 会替换成时间戳
        /// {yyyy} 会替换成四位年份
        /// {yy} 会替换成两位年份
        /// {mm} 会替换成两位月份
        /// {dd} 会替换成两位日期
        /// {hh} 会替换成两位小时
        /// {ii} 会替换成两位分钟
        /// {ss} 会替换成两位秒
        /// 非法字符 \ : * ? " < > |
        /// 具请体看线上文档: fex.baidu.com/ueditor/#use-format_upload_filename
        /// </summary>
        [JsonProperty("imagePathFormat")]
        public string ImagePathFormat { get; set; }

        #endregion

        #region  涂鸦图片上传配置项
        /// <summary>
        /// 执行上传涂鸦的action名称
        /// </summary>
        [JsonProperty("scrawlActionName")]
        public string ScrawlActionName { get; set; }
        /// <summary>
        /// 提交的图片表单名称
        /// </summary>
        [JsonProperty("scrawlFieldName")]
        public string ScrawlFieldName { get; set; }
        /// <summary>
        /// 上传保存路径,可以自定义保存路径和文件名格式
        /// </summary>
        [JsonProperty("scrawlPathFormat")]
        public string ScrawlPathFormat { get; set; }
        /// <summary>
        /// 上传大小限制，单位B
        /// </summary>
        [JsonProperty("scrawlMaxSize")]
        public int ScrawlMaxSize { get; set; }
        /// <summary>
        /// 图片访问路径前缀 
        /// </summary>
        [JsonProperty("scrawlUrlPrefix")]
        public string ScrawlUrlPrefix { get; set; }

        [JsonProperty("scrawlInsertAlign")]
        public string ScrawlInsertAlign { get; set; }
        #endregion

        #region  截图工具上传
        /// <summary>
        /// 执行上传截图的action名称
        /// </summary>
        [JsonProperty("snapscreenActionName")]
        public string SnapscreenActionName { get; set; }
        /// <summary>
        /// 上传保存路径,可以自定义保存路径和文件名格式
        /// </summary>
        [JsonProperty("snapscreenPathFormat")]
        public string SnapscreenPathFormat { get; set; }
        /// <summary>
        /// 图片访问路径前缀
        /// </summary>
        [JsonProperty("snapscreenUrlPrefix")]
        public string SnapscreenUrlPrefix { get; set; }
        /// <summary>
        ///插入的图片浮动方式
        /// </summary>
        [JsonProperty("snapscreenInsertAlign")]
        public string SnapscreenInsertAlign { get; set; }
        #endregion

        #region  抓取远程图片配置
        /// <summary>
        /// 执行上传截图的action名称
        /// </summary>
        [JsonProperty("catcherLocalDomain")]
        public string[] CatcherLocalDomain { get; set; }
        /// <summary>
        ///  执行抓取远程图片的action名称 
        /// </summary>
        [JsonProperty("catcherActionName")]
        public string CatcherActionName { get; set; }
        /// <summary>
        ///提交的图片列表表单名称
        /// </summary>
        [JsonProperty("catcherFieldName")]
        public string CatcherFieldName { get; set; }
        /// <summary>
        /// 上传保存路径,可以自定义保存路径和文件名格式
        /// </summary>
        [JsonProperty("catcherPathFormat")]
        public string CatcherPathFormat { get; set; }
        /// <summary>
        /// 图片访问路径前缀
        /// </summary>
        [JsonProperty("catcherUrlPrefix")]
        public string CatcherUrlPrefix { get; set; }
        /// <summary>
        /// 上传大小限制，单位B
        /// </summary>
        [JsonProperty("catcherMaxSize")]
        public int CatcherMaxSize { get; set; }
        /// <summary>
        ///  抓取图片格式显示
        /// </summary>
        [JsonProperty("catcherAllowFiles")]
        public string[] CatcherAllowFiles { get; set; }
        #endregion

        #region  上传视频配置
        /// <summary>
        ///  执行上传视频的action名称 
        /// </summary>
        [JsonProperty("videoActionName")]
        public string VideoActionName { get; set; }
        /// <summary>
        /// 提交的视频表单名称
        /// </summary>
        [JsonProperty("videoFieldName")]
        public string VideoFieldName { get; set; }
        /// <summary>
        ///  上传保存路径,可以自定义保存路径和文件名格式 
        /// </summary>
        [JsonProperty("videoPathFormat")]
        public string VideoPathFormat { get; set; }
        /// <summary>
        ///  视频访问路径前缀
        /// </summary>
        [JsonProperty("videoUrlPrefix")]
        public string VideoUrlPrefix { get; set; }
        /// <summary>
        ///  上传大小限制，单位B，默认100MB
        /// </summary>
        [JsonProperty("videoMaxSize")]
        public int VideoMaxSize { get; set; }
        /// <summary>
        ///  上传视频格式显示
        /// </summary>
        [JsonProperty("videoAllowFiles")]
        public string[] VideoAllowFiles { get; set; }
        #endregion

        #region  上传文件配置
        /// <summary>
        ///  controller里,执行上传视频的action名称
        /// </summary>
        [JsonProperty("fileActionName")]
        public string FileActionName { get; set; }
        /// <summary>
        ///  提交的文件表单名称
        /// </summary>
        [JsonProperty("fileFieldName")]
        public string FileFieldName { get; set; }
        /// <summary>
        ///  上传保存路径,可以自定义保存路径和文件名格式
        /// </summary>
        [JsonProperty("filePathFormat")]
        public string FilePathFormat { get; set; }
        /// <summary>
        ///  文件访问路径前缀
        /// </summary>
        [JsonProperty("fileUrlPrefix")]
        public string FileUrlPrefix { get; set; }
        /// <summary>
        ///  上传大小限制，单位B，默认50MB
        /// </summary>
        [JsonProperty("fileMaxSize")]
        public int FileMaxSize { get; set; }
        /// <summary>
        ///  上传文件格式显示
        /// </summary>
        [JsonProperty("fileAllowFiles")]
        public string[] FileAllowFiles { get; set; }
        #endregion

        #region  列出指定目录下的图片
        /// <summary>
        ///  执行图片管理的action名称
        /// </summary>
        [JsonProperty("imageManagerActionName")]
        public string ImageManagerActionName { get; set; }
        /// <summary>
        /// 指定要列出图片的目录
        /// </summary>
        [JsonProperty("imageManagerListPath")]
        public string ImageManagerListPath { get; set; }
        /// <summary>
        ///  每次列出文件数量
        /// </summary>
        [JsonProperty("imageManagerListSize")]
        public int ImageManagerListSize { get; set; }
        /// <summary>
        ///图片访问路径前缀
        /// </summary>
        [JsonProperty("imageManagerUrlPrefix")]
        public string ImageManagerUrlPrefix { get; set; }
        /// <summary>
        /// 插入的图片浮动方式
        /// </summary>
        [JsonProperty("imageManagerInsertAlign")]
        public string ImageManagerInsertAlign { get; set; }
        /// <summary>
        /// 列出的文件类型
        /// </summary>
        [JsonProperty("imageManagerAllowFiles")]
        public string[] ImageManagerAllowFiles { get; set; }
        #endregion

        #region  列出指定目录下的文件
        /// <summary>
        ///执行文件管理的action名称
        /// </summary>
        [JsonProperty("fileManagerActionName")]
        public string FileManagerActionName { get; set; }
        /// <summary>
        /// 指定要列出文件的目录
        /// </summary>
        [JsonProperty("fileManagerListPath")]
        public string FileManagerListPath { get; set; }
        /// <summary>
        /// 文件访问路径前缀
        /// </summary>
        [JsonProperty("fileManagerUrlPrefix")]
        public string FileManagerUrlPrefix { get; set; }
        /// <summary>
        /// 每次列出文件数量
        /// </summary>
        [JsonProperty("fileManagerListSize")]
        public int FileManagerListSize { get; set; }
        /// <summary>
        /// 列出的文件类型
        /// </summary>
        [JsonProperty("fileManagerAllowFiles")]
        public string[] FileManagerAllowFiles { get; set; }

        /// <summary>
        /// 上传文件保存目录
        /// </summary>
        [JsonIgnore]
        public string ImageSaveDirectory = null;
        /// <summary>
        /// 上传文件保存目录
        /// </summary>
        [JsonIgnore]
        public string ScrawlSaveDirectory = null;
        /// <summary>
        /// 上传文件保存目录
        /// </summary>
        [JsonIgnore]
        public string VideoSaveDirectory = null;
        /// <summary>
        /// 上传文件保存目录
        /// </summary>
        [JsonIgnore]
        public string FileSaveDirectory = null;
        
        #endregion

        public static Configuration GetDefault()
        {
            var settings = new Configuration();

            string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "upload");
            settings.ImageSaveDirectory = Path.Combine(baseDir, "image");
            settings.ScrawlSaveDirectory = Path.Combine(baseDir, "image");
            settings.VideoSaveDirectory = Path.Combine(baseDir, "video");
            settings.FileSaveDirectory = Path.Combine(baseDir, "file");

            #region 上传图片配置项
            settings.ImageActionName = "uploadimage";
            settings.ImageFieldName = "upfile";
            settings.ImageMaxSize = 2048000;
            settings.ImageAllowFiles = new string[] { ".png", ".jpg", ".jpeg", ".gif", ".bmp" };
            settings.ImageCompressEnable = true;
            settings.ImageCompressBorder = 1600;
            settings.ImageInsertAlign = "none";
            settings.ImageUrlPrefix = "upload/image";
            settings.ImagePathFormat = "{yyyy}{mm}{dd}/{time}{rand:6}";
            #endregion
            #region 涂鸦图片上传配置项
            settings.ScrawlActionName = "uploadscrawl";
            settings.ScrawlFieldName = "upfile";
            settings.ScrawlPathFormat = "{yyyy}{mm}{dd}/{time}{rand:6}";
            settings.ScrawlMaxSize = 2048000;
            settings.ScrawlUrlPrefix = "/upload/image/";
            settings.ScrawlInsertAlign = "none";
            #endregion
            #region 截图工具上传
            settings.SnapscreenActionName = "uploadimage";
            settings.SnapscreenPathFormat = "{yyyy}{mm}{dd}/{time}{rand:6}";
            settings.SnapscreenUrlPrefix = "/upload/image/";
            settings.SnapscreenInsertAlign = "none";
            #endregion
            #region 抓取远程图片配置
            settings.CatcherLocalDomain = new string[] { "127.0.0.1", "localhost", "img.baidu.com" };
            settings.CatcherActionName = "catchimage";
            settings.CatcherFieldName = "source";
            settings.CatcherPathFormat = "{yyyy}{mm}{dd}/{time}{rand:6}";
            settings.CatcherUrlPrefix = "/upload/image/";
            settings.CatcherMaxSize = 2048000;
            settings.CatcherAllowFiles = new string[] { ".png", ".jpg", ".jpeg", ".gif", ".bmp" };

            #endregion
            #region 上传视频配置
            settings.VideoActionName = "uploadvideo";
            settings.VideoFieldName = "upfile";
            settings.VideoPathFormat = "{yyyy}{mm}{dd}/{time}{rand:6}";
            settings.VideoUrlPrefix = "/upload/video/";
            settings.VideoMaxSize = 102400000;
            settings.VideoAllowFiles = new string[] {".flv", ".swf", ".mkv", ".avi", ".rm", ".rmvb", ".mpeg", ".mpg",
        ".ogg", ".ogv", ".mov", ".wmv", ".mp4", ".webm", ".mp3", ".wav", ".mid" };
            #endregion
            #region 上传文件配置
            settings.FileActionName = "uploadfile";
            settings.FileFieldName = "upfile";
            settings.FilePathFormat = "{yyyy}{mm}{dd}/{time}{rand:6}";
            settings.FileUrlPrefix = "/upload/file/";
            settings.FileMaxSize = 51200000;
            settings.FileAllowFiles = new string[] {".png", ".jpg", ".jpeg", ".gif", ".bmp",
        ".flv", ".swf", ".mkv", ".avi", ".rm", ".rmvb", ".mpeg", ".mpg",
        ".ogg", ".ogv", ".mov", ".wmv", ".mp4", ".webm", ".mp3", ".wav", ".mid",
        ".rar", ".zip", ".tar", ".gz", ".7z", ".bz2", ".cab", ".iso",
        ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".pdf", ".txt", ".md", ".xml" };
            #endregion
            #region 列出指定目录下的图片
            settings.ImageManagerActionName = "listimage";
            settings.ImageManagerListPath = "/upload/image";
            settings.ImageManagerListSize = 20;
            settings.ImageManagerUrlPrefix = "/ueditor/net/";
            settings.ImageManagerInsertAlign = "none";
            settings.ImageManagerAllowFiles = new string[] { ".png", ".jpg", ".jpeg", ".gif", ".bmp" };
            #endregion
            #region 列出指定目录下的文件
            settings.FileManagerActionName = "listfile";
            settings.FileManagerListPath = "/upload/file";
            settings.FileManagerUrlPrefix = "/ueditor/net/";
            settings.FileManagerListSize = 20;
            settings.FileManagerAllowFiles = new string[]{  ".png", ".jpg", ".jpeg", ".gif", ".bmp",
                    ".flv", ".swf", ".mkv", ".avi", ".rm", ".rmvb", ".mpeg", ".mpg",
                    ".ogg", ".ogv", ".mov", ".wmv", ".mp4", ".webm", ".mp3", ".wav", ".mid",
                    ".rar", ".zip", ".tar", ".gz", ".7z", ".bz2", ".cab", ".iso",
                    ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".pdf", ".txt", ".md", ".xml"
            };
            #endregion
            return settings;
        }
    }
}
