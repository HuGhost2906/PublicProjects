#pragma checksum "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe1b5caac2b59e82f1933ad135e150507198345"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Authors : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3><b>Enter Author Information</b></h3>\r\n    <hr>\r\n    \r\n    ");
            __builder.OpenComponent<CuriousDriveRazorLibrary.ServerValidations>(4);
            __builder.AddAttribute(5, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                  IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                     Result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddContent(9, 
#nullable restore
#line 14 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
         RecordName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                      author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                              SaveAuthor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-12 row");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label class=\"col-2 font-weight-bold\">first name :</label>\r\n            ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control col-3");
                __builder2.AddAttribute(23, "placeholder", "first name");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                                             author.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => author.FirstName = __value, author.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddElementReferenceCapture(26, (__value) => {
#nullable restore
#line 22 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                         firstNameTextBox = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            &nbsp;");
                __Blazor.BlazorApp.Pages.Authors.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 23 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-12 row");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label class=\"col-2 font-weight-bold\">last name :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control col-3");
                __builder2.AddAttribute(38, "placeholder", "last name");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                               author.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => author.LastName = __value, author.LastName))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => author.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            &nbsp;");
                __Blazor.BlazorApp.Pages.Authors.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 29 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-12 row");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.AddMarkupContent(50, "<label class=\"col-2 font-weight-bold\">email address :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "class", "form-control col-3");
                __builder2.AddAttribute(53, "placeholder", "email address");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                               author.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => author.EmailAddress = __value, author.EmailAddress))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => author.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n            &nbsp;");
                __Blazor.BlazorApp.Pages.Authors.TypeInference.CreateValidationMessage_2(__builder2, 58, 59, 
#nullable restore
#line 53 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-12 row");
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.AddMarkupContent(65, "<label class=\"col-2 font-weight-bold\">salary :</label>\r\n            ");
                __Blazor.BlazorApp.Pages.Authors.TypeInference.CreateInputNumber_3(__builder2, 66, 67, "form-control col-3", 68, 
#nullable restore
#line 58 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                                                 author.Salary

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => author.Salary = __value, author.Salary)), 70, () => author.Salary);
                __builder2.AddMarkupContent(71, "\r\n            &nbsp;");
                __Blazor.BlazorApp.Pages.Authors.TypeInference.CreateValidationMessage_4(__builder2, 72, 73, 
#nullable restore
#line 59 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                            () => author.Salary

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(76, @"<div class=""col-12 row"">
            <span class=""col-2""></span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
            <span>&nbsp;</span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
        </div>

    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-10");
            __builder.AddMarkupContent(81, "\r\n\r\n    ");
            __builder.AddMarkupContent(82, "<h3><b>Authors</b></h3>\r\n\r\n    ");
            __builder.OpenElement(83, "table");
            __builder.AddAttribute(84, "class", "table");
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.AddMarkupContent(86, @"<thead>
            <tr>
                <th>AuthorId</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>City</th>
                <th>Email Address</th>
                <th>Salary</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(87, "tbody");
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 91 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
             foreach (var author in authorList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "            ");
            __builder.OpenElement(90, "tr");
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "td");
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(94);
            __builder.AddAttribute(95, "href", 
#nullable restore
#line 95 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                                   string.Format("/authors/authordetail/{0}",@author.AuthorId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.AddContent(98, 
#nullable restore
#line 96 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                         author.AuthorId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "td");
            __builder.AddContent(103, 
#nullable restore
#line 99 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                     author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.OpenElement(105, "td");
            __builder.AddContent(106, 
#nullable restore
#line 100 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                     author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 101 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                     author.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 102 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                     author.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.OpenElement(114, "td");
            __builder.AddContent(115, "$");
            __builder.AddContent(116, 
#nullable restore
#line 103 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
                      author.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 105 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Authors.razor"
       

    public Author author { get; set; }
    public List<Author> authorList { get; set; }


    public bool IsVisible { get; set; }
    public bool Result { get; set; }
    public string RecordName { get; set; }
    public string[] Cities { get; set; }

    ElementReference firstNameTextBox;

    protected override void OnInitialized()
    {
        Console.WriteLine("Authors - OnInitialized");
        base.OnInitialized();
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Authors - OnInitializedAsync");

        author = new Author();
        //authorList = await authorService.GetAuthors();

        await Http.GetJsonAsync<List<Author>>("https://localhost:44394/api/authors");

        await base.OnInitializedAsync();
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("Authors - OnParametersSet");
        base.OnParametersSet();
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("Authors - OnParametersSetAsync");
        await base.OnParametersSetAsync();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("Authors - OnAfterRender - firstRender = " + firstRender);
        base.OnAfterRender(firstRender);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("Authors - OnAfterRenderAsync - firstRender = " + firstRender);

        //if (firstRender && Cities == null)
        //{
        //    Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

        //    StateHasChanged();
        //}

        await base.OnAfterRenderAsync(firstRender);
    }

    protected override bool ShouldRender()
    {
        Console.WriteLine("Authors - ShouldRender");
        return base.ShouldRender();
    }

    public void Dispose()
    {
        Console.WriteLine("Authors - Dispose");
    }

    private async Task SaveAuthor()
    {
        Result = await authorService.SaveAuthor(author);
        IsVisible = true;

        var firstName = author.FirstName;
        var lastName = author.LastName;

        RecordName = firstName + " " + lastName;

        author = new Author();

        //await JSRuntime.InvokeVoidAsync("saveMessage", firstName, lastName);
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", firstNameTextBox);
    }

    private async Task DeleteAuthor(string authorId)
    {
        var confirm = await JSRuntime.InvokeAsync<bool>("confirmDelete");

        if(confirm)
            await authorService.DeleteAuthor(authorId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService authorService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Authors
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
