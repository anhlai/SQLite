using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GrdCboJubsuGubunArgs : IContractArgs
    {

        public PHY2001U04GrdCboJubsuGubunArgs() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GrdCboJubsuGubunRequest();
        }
    }
}