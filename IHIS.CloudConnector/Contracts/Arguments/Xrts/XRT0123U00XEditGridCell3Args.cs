using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0123U00XEditGridCell3Args : IContractArgs
    {

        public XRT0123U00XEditGridCell3Args() { }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0123U00XEditGridCell3Request();
        }
    }
}