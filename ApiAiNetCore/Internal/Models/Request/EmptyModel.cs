using ApiAiNetCore.Internal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Request
{
    internal class EmptyModel : IResponse
    {
        public StatusJsonModel Status { get; set; }
    }
}
