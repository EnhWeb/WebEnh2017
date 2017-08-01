UEditor For asp.net
========

正在开发中...(应该存在Bug和不合理的地方,随时修改)

基于官方 .net 示例项目，用在asp.net项目中

##开发目标：

* 服务端只需要安装一个库，然后简单配置一下
* 注册一下路由，就可以用
* 上传的文件不一定放在网站下面，随便放在哪里都可以，可以是一个特定的目录，然后搭建一个静态资源网站

##安装

```

PM > Install-Package KAI.UEditor

```

##第一步：注册路由

```csharp

routes.Add(new UEditor.UEditorRoute("/ueditor/demo", UEditorConfigure));

```

一个网站,可以注册多个UEditor Route,每个Route对应有各自的配置和处理程序

##第二步：配置UEditor

```csharp

public static void UeditorConfigure(UEditor.Configuration settings)
{
    settings.ImageSaveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "upload/image/");
    settings.ImageUrlPrefix = "/upload/image/";
    ...
}

```
UEditor默认的配置参考UEditor.Configuration类实现


##第三步：配置UEditor前端

```javascript

serverUrl: "/ueditor/demo"

```

serverUrl是注册路由时指定的URL


##项目依赖项

JSON.NET

.net 4.5