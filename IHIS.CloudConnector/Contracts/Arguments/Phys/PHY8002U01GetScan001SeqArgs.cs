using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01GetScan001SeqArgs : IContractArgs
    {

        public PHY8002U01GetScan001SeqArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01GetScan001SeqRequest();
        }
    }
}