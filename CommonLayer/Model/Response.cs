using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Model
{
    public class Response<T>
    {
        public Response()
        {
            Success = false;
            Message = null;
            Data = new List<T>();
        }
        public bool Success { get; set; }

        public string Message { get; set; }

        public List<T> Data { get; set; }
    }
}
