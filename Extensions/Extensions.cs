using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekUygulama.Extensions
{
    static public class Extensions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value="",string placeHolder="")
        => htmlHelper.TextBox(name,value,new 
        {
            style="background-color:gray;color:beige;font-size=19px;",
            @class= "form-input",
            a = "a",
            b = "b",
            placeHolder = placeHolder
        });
        
    }
}
