using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSRAdmin.Controllers
{
    public abstract class BaseController : Controller
    {       

    }
     /// <summary> /// Example Base Controller /// </summary> /// <typeparam name="TModel">The type of the inheriting controllers' models</typeparam> 
//     public abstract class ExampleBaseController<TModel> 
//         : FormController<TModel> where TModel : BaseModel, new() { 
//  /// <summary>  /// In most cases, this should simply return full access and permissions should be handed by the navigation framework  
//         /// However, if that is not possible because of implementation details specific to this section, use this method to   
//         /// indicate that this entire area needs permission to access a particular access area. 
//         /// Inheriting controllers  /// may then choose to override it or not according to their needs.   /// </summary>  
///// <returns>User's access level based on permissions</returns>  
//protected override AccessLevel GetPagePermission() 
//{   
//    return Permissions.GetUserPermissionByAccessArea(Model.UserInfo.AccountID, Model.UserInfo.UserLogin, UserAccessArea.EVENT_DETAILS_AND_ADMINISTRATION);  
//} 
//  /// <summary>  /// Converts a form mode string to a FormMode enum based on user permissions and the HTTP method being used  /// </summary>  /// <param name="mode"></param>  /// <returns></returns>  
//  protected FormMode GetFormMode(string mode) 
//  {   
//      return CvtFormHelper.GetFormMode(GetPagePermission(), mode, (HttpVerbs)Enum.Parse(typeof(HttpVerbs), HttpContext.Request.HttpMethod, true));  
//  } 

// } 

}
