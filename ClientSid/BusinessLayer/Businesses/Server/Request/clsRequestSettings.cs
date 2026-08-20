using System;
using System.Net;
using System.Net.Http;
using static ClientSideBusinessLayer.clsReturnResult;


namespace ClientSideBusinessLayer
{
internal static class clsRequestSettings
     {
        internal static HttpClient Request { get; private set; }

        private static string BasedUri  => "https://localhost:7255";

        static clsRequestSettings()
        {
             Request= new HttpClient();
            Request.BaseAddress = new Uri(BasedUri);
        }

        internal static clsReturnResult.enReturnResult ConvertToReturnResult(HttpStatusCode StatusCode)
        {
            switch (StatusCode)
            {
                case HttpStatusCode.OK:
                    return clsReturnResult.enReturnResult.Success;
                case HttpStatusCode.NotFound:
                    return clsReturnResult.enReturnResult.NotFound;
                case HttpStatusCode.InternalServerError:
                    return clsReturnResult.enReturnResult.ServerError;
                case HttpStatusCode.BadRequest:
                    return clsReturnResult.enReturnResult.InvalidInputs;
                case HttpStatusCode.Created:
                    return enReturnResult.Success;
                case HttpStatusCode.Found:
                    return clsReturnResult.enReturnResult.Found;

            }

            return clsReturnResult.enReturnResult.None;
        }
    }
}
