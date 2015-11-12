using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ComboADM3200CbxActorArgs : IContractArgs
    {

        public ComboADM3200CbxActorArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComboADM3200CbxActorRequest();
        }
    }
}