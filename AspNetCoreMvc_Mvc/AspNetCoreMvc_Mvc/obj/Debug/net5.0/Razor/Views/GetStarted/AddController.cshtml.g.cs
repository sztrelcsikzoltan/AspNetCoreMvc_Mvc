#pragma checksum "C:\Data\pers dev\IT\KKSZKI\back end\211013 MVC beadando\AspNetCoreMvc_Mvc\AspNetCoreMvc_Mvc\Views\GetStarted\AddController.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60140d3e2e04af79ce639a6463c25f17ca3698ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GetStarted_AddController), @"mvc.1.0.view", @"/Views/GetStarted/AddController.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Data\pers dev\IT\KKSZKI\back end\211013 MVC beadando\AspNetCoreMvc_Mvc\AspNetCoreMvc_Mvc\Views\_ViewImports.cshtml"
using AspNetCoreMvc_Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\pers dev\IT\KKSZKI\back end\211013 MVC beadando\AspNetCoreMvc_Mvc\AspNetCoreMvc_Mvc\Views\_ViewImports.cshtml"
using AspNetCoreMvc_Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60140d3e2e04af79ce639a6463c25f17ca3698ff", @"/Views/GetStarted/AddController.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8f896a9f1199a05e02d8a830325cc6fb68bd59", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GetStarted_AddController : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GetStarted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetStarted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Data\pers dev\IT\KKSZKI\back end\211013 MVC beadando\AspNetCoreMvc_Mvc\AspNetCoreMvc_Mvc\Views\GetStarted\AddController.cshtml"
  
    ViewData["Title"] = "Add a Controller";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"div-flex\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60140d3e2e04af79ce639a6463c25f17ca3698ff5188", async() => {
                WriteLiteral("Previous: Get started");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span class=\"span-flex\"></span>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60140d3e2e04af79ce639a6463c25f17ca3698ff6900", async() => {
                WriteLiteral("Next: Add a View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <h2>Part 2, add a Controller to an ASP.NET Core MVC app</h2>

    <p>The Model-View-Controller (MVC) architectural pattern separates an app into three main components: <strong>M</strong>odel, <strong>V</strong>iew, and <strong>C</strong>ontroller. The MVC pattern helps you create apps that are more testable and easier to update than traditional monolithic apps.</p>
    <p>MVC-based apps contain:</p>
    <ul>
        <li><strong>M</strong>odels: Classes that represent the data of the app. The model classes use validation logic to enforce business rules for that data. Typically, model objects retrieve and store model state in a database. In this tutorial, a <code>Movie</code> model retrieves movie data from a database, provides it to the view or updates it. Updated data is written to a database.</li>
        <li><strong>V</strong>iews: Views are the components that display the app's user interface (UI). Generally, this UI displays the model data.</li>
        <li>
            <strong");
            WriteLiteral(@">C</strong>ontrollers: Classes that:
            <ul>
                <li>Handle browser requests.</li>
                <li>Retrieve model data.</li>
                <li>Call view templates that return a response.</li>
            </ul>
        </li>
    </ul>
    <p>In an MVC app, the view only displays information. The controller handles and responds to user input and interaction. For example, the controller handles URL segments and query-string values, and passes these values to the model. The model might use these values to query the database. For example:</p>
    <ul>
        <li><code>https://localhost:5001/Home/Privacy</code>: specifies the <code>Home</code> controller and the <code>Privacy</code> action.</li>
        <li><code>https://localhost:5001/Movies/Edit/5</code>: is a request to edit the movie with ID=5 using the <code>Movies</code> controller and the <code>Edit</code> action, which are detailed later in the tutorial.</li>
    </ul>
    <p>Route data is explained later in the tuto");
            WriteLiteral(@"rial.</p>
    <p>The MVC architectural pattern separates an app into three main groups of components: Models, Views, and Controllers. This pattern helps to achieve separation of concerns: The UI logic belongs in the view. Input logic belongs in the controller. Business logic belongs in the model. This separation helps manage complexity when building an app, because it enables work on one aspect of the implementation at a time without impacting the code of another. For example, you can work on the view code without depending on the business logic code.</p>
    <p>These concepts are introduced and demonstrated in this tutorial series while building a movie app. The MVC project contains folders for the <em>Controllers</em> and <em>Views</em>.</p>
    <h4 id=""add-a-controller"">Add a controller</h4>
    <p>In <strong>Solution Explorer</strong>, right-click <strong>Controllers &gt; Add &gt; Controller</strong>.</p>
    <p><img src=""/img/addcontroller01-add_controllercopyvs19v16.9.png"" alt=""Solution Explorer, r");
            WriteLiteral(@"ight click Controllers &gt; Add &gt; Controller"" title=""Solution Explorer, right click Controllers &gt; Add &gt; Controller""></p>
    <p>In the <strong>Add New Scaffolded Item</strong> dialog box, select <strong>MVC Controller - Empty</strong> &gt; <strong>Add</strong>.</p>
    <p><img src=""/img/addcontroller02-accopyvs19v16.9.png"" alt=""Add MVC controller"" tit=""Add MVC controller""></p>
    <p>In the <strong>Add New Item - MvcMovie</strong> dialog, enter <strong>HelloWorldController.cs</strong> and select <strong>Add</strong>.</p>

    <p>Replace the contents of <em>Controllers/HelloWorldController.cs</em> with the following code:</p>
<pre><code class=""lang-csharp"">using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return &quot;This is my default action...&quot;;
        }

        // 
       ");
            WriteLiteral(@" // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return &quot;This is the Welcome action method...&quot;;
        }
    }
}
</code></pre>

    <p>Every <code>public</code> method in a controller is callable as an HTTP endpoint. In the sample above, both methods return a string. Note the comments preceding each method.</p>
    <p>An HTTP endpoint:</p>
    <ul>
        <li>Is a targetable URL in the web application, such as <code>https://localhost:5001/HelloWorld</code>.</li>
        <li>
            Combines:
            <ul>
                <li>The protocol used: <code>HTTPS</code>.</li>
                <li>The network location of the web server, including the TCP port: <code>localhost:5001</code>.</li>
                <li>The target URI: <code>HelloWorld</code>.</li>
            </ul>
        </li>
    </ul>
    <p>The first comment states this is an <a href=""https://developer.mozilla.org/docs/Web/HTTP/Methods/GET"" data-linktype=""external"">HTTP GET<");
            WriteLiteral(@"/a> method that's invoked by appending <code>/HelloWorld/</code> to the base URL.</p>
    <p>The second comment specifies an <a href=""https://developer.mozilla.org/docs/Web/HTTP/Methods"" data-linktype=""external"">HTTP GET</a> method that's invoked by appending <code>/HelloWorld/Welcome/</code> to the URL. Later on in the tutorial, the scaffolding engine is used to generate <code>HTTP POST</code> methods, which update data.</p>
    <p>Run the app without the debugger.</p>
    <p>Append &quot;HelloWorld&quot; to the path in the address bar. The <code>Index</code> method returns a string.</p>
    <p><img src=""/img/addcontroller03-hell1.png"" alt=""Browser window showing an app response of This is my default action"" title=""Browser window showing an app response of This is my default action""></p>
    <p>MVC invokes controller classes, and the action methods within them, depending on the incoming URL. The default <a href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0"" da");
            WriteLiteral(@"ta-linktype=""relative-path"">URL routing logic</a> used by MVC, uses a format like this to determine what code to invoke:</p>
    <p><code>/[Controller]/[ActionName]/[Parameters]</code></p>
    <p>The routing format is set in the <em>Program.cs</em> file.</p>
<pre><code class=""lang-csharp"" highlight-lines=""3"">app.MapControllerRoute(
    name: &quot;default&quot;,
    pattern: &quot;{controller=Home}/{action=Index}/{id?}&quot;);
</code></pre>
    <p>When you browse to the app and don't supply any URL segments, it defaults to the &quot;Home&quot; controller and the &quot;Index&quot; method specified in the template line highlighted above.  In the preceding URL segments:</p>
    <ul>
        <li>The first URL segment determines the controller class to run. So <code>localhost:5001/HelloWorld</code> maps to the <strong>HelloWorld</strong> Controller class.</li>
        <li>The second part of the URL segment determines the action method on the class. So <code>localhost:5001/HelloWorld/Index</code> causes t");
            WriteLiteral(@"he <code>Index</code> method of the <code>HelloWorldController</code> class to run. Notice that you only had to browse to <code>localhost:5001/HelloWorld</code> and the <code>Index</code> method was called by default. <code>Index</code> is the default method that will be called on a controller if a method name isn't explicitly specified.</li>
        <li>The third part of the URL segment ( <code>id</code>) is for route data. Route data is explained later in the tutorial.</li>
    </ul>
    <p>Browse to: <code>https://localhost:{PORT}/HelloWorld/Welcome</code>. Replace <code>{PORT}</code> with your port number.</p>
    <p>The <code>Welcome</code> method runs and returns the string <code>This is the Welcome action method...</code>. For this URL, the controller is <code>HelloWorld</code> and <code>Welcome</code> is the action method. You haven't used the <code>[Parameters]</code> part of the URL yet.</p>
    <p><img src=""/img/addcontroller04-welcome.png"" alt=""Browser window showing an application response o");
            WriteLiteral(@"f This is the Welcome action method"" title=""Browser window showing an application response of This is the Welcome action method""></p>
    <p>Modify the code to pass some parameter information from the URL to the controller. For example, <code>/HelloWorld/Welcome?name=Rick&amp;numtimes=4</code>.</p>
    <p>Change the <code>Welcome</code> method to include two parameters as shown in the following code.</p>
<pre><code class=""lang-csharp"">// GET: /HelloWorld/Welcome/ 
// Requires using System.Text.Encodings.Web;
public string Welcome(string name, int numTimes = 1)
{
    return HtmlEncoder.Default.Encode($&quot;Hello {name}, NumTimes is: {numTimes}&quot;);
}
</code></pre>
    <p>The preceding code:</p>
    <ul>
        <li>Uses the C# optional-parameter feature to indicate that the <code>numTimes</code> parameter defaults to 1 if no value is passed for that parameter.</li>
        <li>Uses <code>HtmlEncoder.Default.Encode</code> to protect the app from malicious input, such as through JavaScript.</li>");
            WriteLiteral(@"
        <li>Uses <a href=""https://docs.microsoft.comhttps://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/interpolated-strings"" data-linktype=""absolute-path"">Interpolated Strings</a> in <code>$&quot;Hello {name}, NumTimes is: {numTimes}&quot;</code>.</li>
    </ul>
    <p>Run the app and browse to: <code>https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&amp;numtimes=4</code>. Replace <code>{PORT}</code> with your port number.</p>
    <p>Try different values for <code>name</code> and <code>numtimes</code> in the URL. The MVC <a href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-5.0"" data-linktype=""relative-path"">model binding</a> system automatically maps the named parameters from the query string to parameters in the method. See <a href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-5.0"" data-linktype=""relative-path"">Model Binding</a> for more information.</p>
    <p><img src=""/img/addcontr");
            WriteLiteral(@"oller05-rick4.png"" alt=""Browser window showing an application response of Hello Rick, NumTimes is: 4"" title=""Browser window showing an application response of Hello Rick, NumTimes is: 4""></p>
    <p>In the previous image:</p>
    <ul>
        <li>The URL segment <code>Parameters</code> isn't used.</li>
        <li>The <code>name</code> and <code>numTimes</code> parameters are passed in the <a href=""https://wikipedia.org/wiki/Query_string"" data-linktype=""external"">query string</a>.</li>
        <li>The <code>?</code> (question mark) in the above URL is a separator, and the query string follows.</li>
        <li>The <code>&amp;</code> character separates field-value pairs.</li>
    </ul>
    <p>Replace the <code>Welcome</code> method with the following code:</p>
<pre><code class=""lang-csharp"">public string Welcome(string name, int ID = 1)
{
    return HtmlEncoder.Default.Encode($&quot;Hello {name}, ID: {ID}&quot;);
}
</code></pre>
    <p>Run the app and enter the following URL: <code>https://local");
            WriteLiteral(@"host:{PORT}/HelloWorld/Welcome/3?name=Rick</code></p>
    <p>In the preceding URL:</p>
    <ul>
        <li>The third URL segment matched the route parameter <code>id</code>.</li>
        <li>The <code>Welcome</code> method contains a parameter <code>id</code> that matched the URL template in the <code>MapControllerRoute</code> method.</li>
        <li>The trailing <code>?</code> starts the <a href=""https://wikipedia.org/wiki/Query_string"" data-linktype=""external"">query string</a>.</li>
    </ul>
<pre><code class=""lang-csharp"" highlight-lines=""3"">app.MapControllerRoute(
    name: &quot;default&quot;,
    pattern: &quot;{controller=Home}/{action=Index}/{id?}&quot;);
</code></pre>
    <p>In the preceding example:</p>
    <ul>
        <li>The third URL segment matched the route parameter <code>id</code>.</li>
        <li>The <code>Welcome</code> method contains a parameter <code>id</code> that matched the URL template in the <code>MapControllerRoute</code> method.</li>
        <li>The trailing <co");
            WriteLiteral("de>?</code> (in <code>id?</code>) indicates the <code>id</code> parameter is optional.</li>\r\n    </ul>\r\n\r\n    <div class=\"div-flex\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60140d3e2e04af79ce639a6463c25f17ca3698ff21452", async() => {
                WriteLiteral("Previous: Get started");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span class=\"span-flex\"></span>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60140d3e2e04af79ce639a6463c25f17ca3698ff23165", async() => {
                WriteLiteral("Next: Add a View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
