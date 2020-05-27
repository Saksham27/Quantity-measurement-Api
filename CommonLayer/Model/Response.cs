/// ================================================
/// File    : Response.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using System.Collections.Generic;

#region CommonLayer.Model
namespace CommonLayer.Model
{
    /// <summary>
    /// Poco class for responses of requests
    /// </summary>
    /// <typeparam name="T"></typeparam>
    #region Response
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
    #endregion
}
#endregion
