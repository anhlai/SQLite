using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00LoadKanaFullArgs : IContractArgs
    {
        private String _text;
        private String _hospCode;

        public String Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00LoadKanaFullArgs() { }

        public OCS0103U00LoadKanaFullArgs(String text, String hospCode)
        {
            this._text = text;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00LoadKanaFullRequest();
        }
    }
}