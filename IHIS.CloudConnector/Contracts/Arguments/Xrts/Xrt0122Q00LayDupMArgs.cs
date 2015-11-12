using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class Xrt0122Q00LayDupMArgs : IContractArgs
    {
        private String _buwiBunryu;

        public String BuwiBunryu
        {
            get { return this._buwiBunryu; }
            set { this._buwiBunryu = value; }
        }

        public Xrt0122Q00LayDupMArgs() { }

        public Xrt0122Q00LayDupMArgs(String buwiBunryu)
        {
            this._buwiBunryu = buwiBunryu;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Xrt0122Q00LayDupMRequest();
        }
    }
}