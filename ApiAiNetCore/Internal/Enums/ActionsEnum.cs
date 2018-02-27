using ApiAiNetCore.Internal.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Enums
{
    internal enum ActionsEnum
    {
        [AlternativeValue("query")]
        Query,

        [AlternativeValue("entities")]
        Entities
    }
}
