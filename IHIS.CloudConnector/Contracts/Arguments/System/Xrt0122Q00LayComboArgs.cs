using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class Xrt0122Q00LayComboArgs : IContractArgs
    {

        public Xrt0122Q00LayComboArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Xrt0122Q00LayComboRequest();
        }
    }
}