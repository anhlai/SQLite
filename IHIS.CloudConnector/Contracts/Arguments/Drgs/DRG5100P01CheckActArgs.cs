using System;
using IHIS.CloudConnector.Contracts.Models.Drgs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
    public class DRG5100P01CheckActArgs : IContractArgs
    {

        public DRG5100P01CheckActArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.DRG5100P01CheckActRequest();
        }
    }
}