using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPLMASTERUPLOADERCboMstTypeArgs : IContractArgs
    {

        public CPLMASTERUPLOADERCboMstTypeArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPLMASTERUPLOADERCboMstTypeRequest();
        }
    }
}