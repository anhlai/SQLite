using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0122U00LayDupDArgs : IContractArgs
    {
        private String _buwiBunryu;
        private String _buwiCode;

        public String BuwiBunryu
        {
            get { return this._buwiBunryu; }
            set { this._buwiBunryu = value; }
        }

        public String BuwiCode
        {
            get { return this._buwiCode; }
            set { this._buwiCode = value; }
        }

        public XRT0122U00LayDupDArgs() { }

        public XRT0122U00LayDupDArgs(String buwiBunryu, String buwiCode)
        {
            this._buwiBunryu = buwiBunryu;
            this._buwiCode = buwiCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0122U00LayDupDRequest();
        }
    }
}