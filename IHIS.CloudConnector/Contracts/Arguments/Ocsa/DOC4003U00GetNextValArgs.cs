using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class DOC4003U00GetNextValArgs : IContractArgs
    {

        public DOC4003U00GetNextValArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.DOC4003U00GetNextValRequest();
        }
    }
}