using ApiAiNetCore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Models
{
    /// <summary>
    /// Services configuration
    /// </summary>
    public class ConfigModel
    {
        #region magic
        internal static string
            BaseUrl = @"https://api.dialogflow.com/v1",
            VersionCode = @"20150910";

        #endregion

        /// <summary>
        /// Each API request requires authentication to identify the agent that is responsible for making the request. Authentication is provided through an access token.
        /// The developer access token is used for managing entities and intents.
        /// </summary>
        public string AccesTokenDeveloper { get; set; }

        /// <summary>
        /// Each API request requires authentication to identify the agent that is responsible for making the request. Authentication is provided through an access token.
        /// The client access token is used for making queries.
        /// </summary>
        public string AccesTokenClient { get; set; }

        /// <summary>
        /// Specifed language in your Api.ai agent
        /// </summary>
        public LanguagesEnum Language { get; set; }

        /// <summary>
        /// Timezone requests parameter
        /// </summary>
        public string TimeZone { get; set; } = System.TimeZone.CurrentTimeZone.StandardName;

        /// <summary>
        /// Session ID for request
        /// </summary>
        public object SessionId { get; set; } = Guid.NewGuid();
    }
}
