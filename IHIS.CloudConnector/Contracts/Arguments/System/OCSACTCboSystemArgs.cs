using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class OCSACTCboSystemArgs : IContractArgs
    {

        public OCSACTCboSystemArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTCboSystemRequest();
        }
    }
}