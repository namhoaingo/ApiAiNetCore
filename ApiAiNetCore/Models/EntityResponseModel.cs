using ApiAiNetCore.Internal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Models
{
    public class EntityResponseModel
    {
        internal EntityResponseModel(EntityJsonModel data)
        {
            Id = data.Id;
            Name = data.Name;
            Count = data.Count;
            Preview = data.Preview;
        }

        /// <summary>
        /// ID of the entity.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Name of the entity.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The total number of synonyms in the entity.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// A string that contains summary information about the entity.
        /// </summary>
        public string Preview { get; }
    }

}
