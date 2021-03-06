﻿using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace WeihanLi.Common.Helpers
{
    public interface IHttpRequester
    {
        #region AddHeader

        IHttpRequester WithHeaders([NotNull]IEnumerable<KeyValuePair<string, string>> customHeaders);

        #endregion AddHeader

        #region UserAgent

        IHttpRequester WithUserAgent(string userAgent);

        #endregion UserAgent

        #region Referer

        IHttpRequester WithReferer(string referer);

        #endregion Referer

        #region Cookie

        IHttpRequester WithCookie(string cookieName, string cookieValue);

        IHttpRequester WithCookie(Cookie cookie);

        IHttpRequester WithCookie(string url, Cookie cookie);

        IHttpRequester WithCookie(CookieCollection cookies);

        IHttpRequester WithCookie(string url, CookieCollection cookies);

        #endregion Cookie

        #region Parameter

        IHttpRequester WithParameters([NotNull] byte[] requestBytes, string contentType);

        IHttpRequester WithFile(string fileName, byte[] fileBytes, string fileKey = "file",
            IEnumerable<KeyValuePair<string, string>> formFields = null);

        IHttpRequester WithFiles(IEnumerable<KeyValuePair<string, byte[]>> files,
            IEnumerable<KeyValuePair<string, string>> formFields = null);

        #endregion Parameter

        #region Execute

        string Execute();

        Task<string> ExecuteAsync();

        HttpResponse ExecuteForResponse();

        Task<HttpResponse> ExecuteForResponseAsync();

        #endregion Execute
    }
}
