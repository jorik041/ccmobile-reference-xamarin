using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using MobFlix.Core.Extensions;

namespace MobFlix.Core.Services.MovieDb
{
    internal class MovieDbServiceClientHandler : HttpClientHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.RequestUri.Query.ToLower().Contains("api_key"))
            {
                request.RequestUri = request.RequestUri.AddParameter("api_key", MovieDbServiceProvider.ApiKey);
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
