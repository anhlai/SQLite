using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0122U00GrdMcodeArgs : IContractArgs
    {
        private String _buwiBunryu;

        public String BuwiBunryu
        {
            get { return this._buwiBunryu; }
            set { this._buwiBunryu = value; }
        }

        public XRT0122U00GrdMcodeArgs() { }

        public XRT0122U00GrdMcodeArgs(String buwiBunryu)
        {
            this._buwiBunryu = buwiBunryu;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0122U00GrdMcodeRequest();
        }
    }
}