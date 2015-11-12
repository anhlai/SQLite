using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0803U00grdOCS0803Args : IContractArgs
    {

        public OCS0803U00grdOCS0803Args() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0803U00grdOCS0803Request();
        }
    }
}