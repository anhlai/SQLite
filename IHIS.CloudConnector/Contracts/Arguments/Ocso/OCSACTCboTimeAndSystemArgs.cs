using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTCboTimeAndSystemArgs : IContractArgs
    {

        public OCSACTCboTimeAndSystemArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTCboTimeAndSystemRequest();
        }
    }
}