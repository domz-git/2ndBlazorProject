#pragma checksum "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e7faff541aedeff0bc5f4caaf8bc4bdd3d8cf9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppDotNet5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using BlazorAppDotNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\_Imports.razor"
using BlazorAppDotNet5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
using TodoList;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Todo (");
#nullable restore
#line 5 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
__builder.AddContent(2, todos.Count(todo => !todo.isDone));

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
#nullable restore
#line 8 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<tr><th>Task</th>\r\n            <th>Due date</th>\r\n            <th>Completed</th></tr>\r\n        ");
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
#nullable restore
#line 17 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
__builder.AddContent(10, todo.title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 18 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
__builder.AddContent(13, todo.dueDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "checkbox");
            __builder.AddAttribute(18, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
                                              todo.isDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.isDone = __value, todo.isDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "Something todo");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
                                           newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "placeholder", "Due date");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
                                     newDueDate

#line default
#line hidden
#nullable disable
            , format: "dd-MM-yyyy"));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newDueDate = __value, newDueDate, format: "dd-MM-yyyy"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
                  addTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Add");
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
 if (!string.IsNullOrEmpty(newTodo))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "p");
#nullable restore
#line 30 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
__builder.AddContent(35, newTodo);

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, " Due: ");
#nullable restore
#line 30 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
__builder.AddContent(37, newDueDate?.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Dominik\source\repos\BlazorAppDotNet5\BlazorAppDotNet5\Pages\Todo.razor"
       
    private string? newTodo;
    private DateTime? newDueDate=null;
    private List<TodoItem> todos = new();

    private void addTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { title = newTodo , dueDate=newDueDate});
            newTodo = string.Empty;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
