using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0118U00FwkOCS0103Args : IContractArgs
    {
        private String _find1;

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public OCS0118U00FwkOCS0103Args() { }

        public OCS0118U00FwkOCS0103Args(String find1)
        {
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0118U00FwkOCS0103Request();
        }
    }
}