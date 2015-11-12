using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ComboNUR0102CboTimeArgs : IContractArgs
    {

        public ComboNUR0102CboTimeArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComboNUR0102CboTimeRequest();
        }
    }
}