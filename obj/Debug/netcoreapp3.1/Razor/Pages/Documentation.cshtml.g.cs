#pragma checksum "C:\Users\Stephen.P\Documents\Projects 2020~\BugTrackerv2\Pages\Documentation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afdd0ba71e753238fc6d1bf44a962000ee4d131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BugTrackerv2.Pages.Pages_Documentation), @"mvc.1.0.razor-page", @"/Pages/Documentation.cshtml")]
namespace BugTrackerv2.Pages
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
#line 1 "C:\Users\Stephen.P\Documents\Projects 2020~\BugTrackerv2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stephen.P\Documents\Projects 2020~\BugTrackerv2\Pages\_ViewImports.cshtml"
using BugTrackerv2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Stephen.P\Documents\Projects 2020~\BugTrackerv2\Pages\_ViewImports.cshtml"
using BugTrackerv2.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afdd0ba71e753238fc6d1bf44a962000ee4d131", @"/Pages/Documentation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e2ca1e5e466c411405dd6e5452282b29737a47", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Documentation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Stephen.P\Documents\Projects 2020~\BugTrackerv2\Pages\Documentation.cshtml"
  
    ViewData["Title"] = "Creating an Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Stephen.P\Documents\Projects 2020~\BugTrackerv2\Pages\Documentation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<h1>2.1. Creating an Account</h1>
<p>If you want to use a particular installation of Bugzilla, first you need to create an account. Ask the administrator responsible for your installation for the URL you should use to access it. If you&rsquo;re test-driving Bugzilla, you can use one of the installations on <a class=""reference external"" href=""https://bugzilla-dev.allizom.org/"">Mozilla&rsquo;s Bugzilla (BMO) test server</a>.</p>
<p>The process of creating an account is similar to many other websites.</p>
<ol class=""arabic"">
<li>
<p class=""first"">On the home page, click the <span class=""guilabel"">New Account</span> link in the header. Enter your email address, then click the <code class=""docutils literal notranslate""><span class=""pre"">Send</span></code> button.</p>
<div class=""admonition note"">
<p class=""first admonition-title"">Note</p>
<p class=""last"">If the <span class=""guilabel"">New Account</span> link is not available, this means that the administrator of the installation has disabled self-r");
            WriteLiteral(@"egistration. Speak to the administrator to find out how to get an account.</p>
</div>
</li>
<li>
<p class=""first"">Within moments, you should receive an email to the address you provided, which contains your login name (generally the same as the email address), and a URL to click to confirm your registration.</p>
</li>
<li>
<p class=""first"">Once you confirm your registration, Bugzilla will ask you your real name (optional, but recommended) and ask you to choose a password. Depending on how your Bugzilla is configured, there may be minimum complexity requirements for the password.</p>
</li>
<li>
<p class=""first"">Now all you need to do is to click the <span class=""guilabel"">Log In</span> link in the header or footer, enter your email address and the password you just chose into the login form, and click the <span class=""guilabel"">Log in</span> button.</p>
</li>
</ol>
<p>You are now logged in. Bugzilla uses cookies to remember you are logged in, so, unless you have cookies disabled or your IP address");
            WriteLiteral(" changes, you should not have to log in again during your session.</p>\r\n<hr class=\"docutils\" />\r\n<p>This documentation undoubtedly has bugs; if you find some, please file them </a>.</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
