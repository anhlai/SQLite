using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0122U00GrdDcodeArgs : IContractArgs
    {
        private String _buwiName;
        private String _buwiCode;
        private String _flag;
        private String _buwiBunryu;

        public String BuwiName
        {
            get { return this._buwiName; }
            set { this._buwiName = value; }
        }

        public String BuwiCode
        {
            get { return this._buwiCode; }
            set { this._buwiCode = value; }
        }

        public String Flag
        {
            get { return this._flag; }
            set { this._flag = value; }
        }

        public String BuwiBunryu
        {
            get { return this._buwiBunryu; }
            set { this._buwiBunryu = value; }
        }

        public XRT0122U00GrdDcodeArgs() { }

        public XRT0122U00GrdDcodeArgs(String buwiName, String buwiCode, String flag, String buwiBunryu)
        {
            this._buwiName = buwiName;
            this._buwiCode = buwiCode;
            this._flag = flag;
            this._buwiBunryu = buwiBunryu;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0122U00GrdDcodeRequest();
        }
    }
}