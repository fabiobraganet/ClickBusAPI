
namespace ClickBusApi.Model.SeatsBlocks
{
    using System.Collections.Generic;

    public class ResponseContent<T>
    {
        public List<T> Request { get; set; } = new List<T>();

    }
}
