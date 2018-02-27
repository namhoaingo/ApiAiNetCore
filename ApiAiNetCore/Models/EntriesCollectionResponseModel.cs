using ApiAiNetCore.Internal.Models;
using ApiAiNetCore.Internal.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiAiNetCore.Models
{
    public class EntriesCollectionResponseModel
    {
        public class EntryResponseModel
        {
            internal EntryResponseModel(EntryJsonModel data)
            {
                Value = data.Value;
                Synonyms = data.Synonyms;
            }

            /// <summary>
            /// For mapping entities: a canonical name to be used in place of synonyms. Example: "New York"
            /// For enum type entities: a string that can contain references to other entities (with or without aliases). Example: "@sys.color:color @size:size @clothes:clothes"
            /// </summary>
            public string Value { get; }

            /// <summary>
            /// Array of strings that can include simple strings (for words and phrases) or references to other entites (with or without aliases).
            /// </summary>
            public List<string> Synonyms { get; }
        }

        internal EntriesCollectionResponseModel(EntriesResponseJsonModel data)
        {
            Id = data.Id;
            Name = data.Name;
            Entries = data.Entries.Select(x => new EntryResponseModel(x));
            IsEnum = data.IsEnum;
            IsAutomatedExpansion = data.AutomatedExpansion;
        }

        /// <summary>
        /// A unique identifier for the entity.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// 	The name of the entity.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// An array of entry objects, which contain reference values and synonyms.
        /// </summary>
        public IEnumerable<EntryResponseModel> Entries { get; }

        /// <summary>
        /// Indicates if the entity is a mapping or an enum type entity.
        /// </summary>
        public bool IsEnum { get; }

        /// <summary>
        /// Indicates if the entity can be automatically expanded.
        /// </summary>
        public bool IsAutomatedExpansion { get; }
    }
}
