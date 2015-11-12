using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0110U00FwkCommonArgs : IContractArgs
    {
        private String _find1;

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public BAS0110U00FwkCommonArgs() { }

        public BAS0110U00FwkCommonArgs(String find1)
        {
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0110U00FwkCommonRequest();
        }
    }
}