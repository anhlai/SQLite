using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ADM102UFwkSysIdArgs : IContractArgs
    {

        public ADM102UFwkSysIdArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM102UFwkSysIdRequest();
        }
    }
}