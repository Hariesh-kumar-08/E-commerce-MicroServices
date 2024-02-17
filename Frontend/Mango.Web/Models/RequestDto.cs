using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.AccessControl;
using Mango.Web.Utility;
using static Mango.Web.Utility.SD;

public class RequestDto
{
    public ApiType ApiType { get; set; } = ApiType.GET;
    public string Url { get; set; }
    public object Data { get; set; }
    public string AccessToken { get; set; }

    //public ContentType ContentType { get; set; } = ContentType.Json;
}
