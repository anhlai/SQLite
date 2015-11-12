using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM103UGetFwkHospitalArgs : IContractArgs
    {

        public ADM103UGetFwkHospitalArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM103UGetFwkHospitalRequest();
        }
    }
}