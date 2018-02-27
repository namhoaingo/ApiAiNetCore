using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Interfaces
{
    internal interface IResponse
    {
        Models.StatusJsonModel Status { get; set; }
    }
}
