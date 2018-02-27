using ApiAiNetCore.Internal.Attributes;
using ApiAiNetCore.Internal.Models.Request;
using ApiAiNetCore.Internal.Models.Responses;
using ApiAiNetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore
{
    /// <summary>
    /// The query endpoint is used to process natural language in the form of text.
    /// </summary>
    public static class QueryService
    {
        /// <summary>
        /// Takes natural language text and information as query parameters.
        /// </summary>
        /// <param name="config">Agent connection configuration</param>
        /// <param name="message">Natural language text to be processed. Query length should not exceed 256 characters.</param>
        /// <returns></returns>
        public static QueryResponseModel SendRequest(ConfigModel config, string message)
        {
            var requestData = new QueryRequestJsonModel
            {
                Query = message,
                SessionId = (config.SessionId ?? Guid.NewGuid()).ToString(),
                Lang = config.Language.GetAlternativeString()
            };

            var result = Internal.RequestHelper.Send<QueryRequestJsonModel, QueryResponseJsonModel>
                (requestData, Internal.Enums.ActionsEnum.Query, System.Net.Http.HttpMethod.Post, config);

            return new QueryResponseModel(result);
        }
    }
}
