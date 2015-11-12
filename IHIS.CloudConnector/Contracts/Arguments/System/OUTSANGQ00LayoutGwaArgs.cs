using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class OUTSANGQ00LayoutGwaArgs : IContractArgs
    {

        public OUTSANGQ00LayoutGwaArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUTSANGQ00LayoutGwaRequest();
        }
    }
}