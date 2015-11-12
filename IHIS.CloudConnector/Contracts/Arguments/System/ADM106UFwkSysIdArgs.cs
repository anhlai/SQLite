using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ADM106UFwkSysIdArgs : IContractArgs
    {

        public ADM106UFwkSysIdArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM106UFwkSysIdRequest();
        }
    }
}