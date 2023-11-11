using System.Net;

namespace Day6_efcore1.ReturnsModel;

public class ReturnModel<T>
{
    public T Data { get; set; }
    public string Message { get; set; }
    public HttpStatusCode StatusCode { get; set; }
}
