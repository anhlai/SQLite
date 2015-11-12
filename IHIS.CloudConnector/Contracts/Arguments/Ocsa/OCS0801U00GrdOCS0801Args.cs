using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0801U00GrdOCS0801Args : IContractArgs
    {

        public OCS0801U00GrdOCS0801Args() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0801U00GrdOCS0801Request();
        }
    }
}