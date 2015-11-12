using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00layDupSetCodeArgs : IContractArgs
    {
        private String _setPart;
        private String _hangmogCode;
        private String _setCode;

        public String SetPart
        {
            get { return this._setPart; }
            set { this._setPart = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String SetCode
        {
            get { return this._setCode; }
            set { this._setCode = value; }
        }

        public OCS0311U00layDupSetCodeArgs() { }

        public OCS0311U00layDupSetCodeArgs(String setPart, String hangmogCode, String setCode)
        {
            this._setPart = setPart;
            this._hangmogCode = hangmogCode;
            this._setCode = setCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00layDupSetCodeRequest();
        }
    }
}