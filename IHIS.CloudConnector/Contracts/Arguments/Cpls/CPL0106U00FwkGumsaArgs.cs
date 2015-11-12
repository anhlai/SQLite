using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0106U00FwkGumsaArgs : IContractArgs
    {
        private String _find1;

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public CPL0106U00FwkGumsaArgs() { }

        public CPL0106U00FwkGumsaArgs(String find1)
        {
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0106U00FwkGumsaRequest();
        }
    }
}