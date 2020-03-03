
namespace ClickBusApi.Model.Base
{
    using System.Collections.Generic;
    
    public class Error
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }

    public class ErrorContent
    {
        public List<Error> Error { get; set; } = new List<Error>();
    }
}
