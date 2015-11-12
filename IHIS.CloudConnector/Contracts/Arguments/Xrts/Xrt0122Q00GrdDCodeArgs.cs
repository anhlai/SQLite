using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class Xrt0122Q00GrdDCodeArgs : IContractArgs
    {
        private String _buwiBunryu;
        private String _flag;
        private String _buwiCode;
        private String _buwiName;

        public String BuwiBunryu
        {
            get { return this._buwiBunryu; }
            set { this._buwiBunryu = value; }
        }

        public String Flag
        {
            get { return this._flag; }
            set { this._flag = value; }
        }

        public String BuwiCode
        {
            get { return this._buwiCode; }
            set { this._buwiCode = value; }
        }

        public String BuwiName
        {
            get { return this._buwiName; }
            set { this._buwiName = value; }
        }

        public Xrt0122Q00GrdDCodeArgs() { }

        public Xrt0122Q00GrdDCodeArgs(String buwiBunryu, String flag, String buwiCode, String buwiName)
        {
            this._buwiBunryu = buwiBunryu;
            this._flag = flag;
            this._buwiCode = buwiCode;
            this._buwiName = buwiName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Xrt0122Q00GrdDCodeRequest();
        }
    }
}