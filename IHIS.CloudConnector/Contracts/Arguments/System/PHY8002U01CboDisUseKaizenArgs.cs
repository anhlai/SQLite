using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class PHY8002U01CboDisUseKaizenArgs : IContractArgs
    {

        public PHY8002U01CboDisUseKaizenArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01CboDisUseKaizenRequest();
        }
    }
}