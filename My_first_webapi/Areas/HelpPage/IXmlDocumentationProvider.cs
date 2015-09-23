using System;
namespace My_first_webapi.Areas.HelpPage
{
    interface IXmlDocumentationProvider
    {
        string GetDocumentation(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor);
        string GetDocumentation(System.Web.Http.Controllers.HttpParameterDescriptor parameterDescriptor);
    }
}
