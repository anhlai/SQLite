using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class OCS0132GetServerIpArgs : IContractArgs
    {

        public OCS0132GetServerIpArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0132GetServerIpRequest();
        }
    }
}