using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0310P01GrdSangMasterArgs : IContractArgs
    {

        public BAS0310P01GrdSangMasterArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0310P01GrdSangMasterRequest();
        }
    }
}