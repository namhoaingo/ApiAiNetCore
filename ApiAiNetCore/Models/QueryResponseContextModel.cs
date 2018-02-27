using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Models
{
    public class QueryResponseContextModel
    {
        internal QueryResponseContextModel(Internal.Models.ContextJsonModel data)
        {
            Name = data.Name;
            Parameters = data.Parameters;
            Lifespan = data.Lifespan;
        }

        /// <summary>
        /// Context name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Dictionary consisting of "parameter_name":"parameter_value" and "parameter_name.original":"original_parameter_value" pairs.
        /// </summary>
        public Dictionary<string, string> Parameters { get; }

        /// <summary>
        /// Number of requests after which the context will expire.
        /// </summary>
        public long Lifespan { get; }
    }

}
