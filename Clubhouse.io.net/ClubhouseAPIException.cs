using System;
using Refit;

namespace Clubhouse.io.net
{
    public class ClubhouseApiException : Exception
    {
        public ClubhouseApiException(ApiException apiException)
        {
            ApiException = apiException;
        }

        public ApiException ApiException { get; set; }
    }
}
