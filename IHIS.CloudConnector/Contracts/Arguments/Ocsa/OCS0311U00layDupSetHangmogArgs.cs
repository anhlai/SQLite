using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00layDupSetHangmogArgs : IContractArgs
    {
        private String _setPart;
        private String _hangmogCode;
        private String _setCode;
        private String _setValueHangmogCode;

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

        public String SetValueHangmogCode
        {
            get { return this._setValueHangmogCode; }
            set { this._setValueHangmogCode = value; }
        }

        public OCS0311U00layDupSetHangmogArgs() { }

        public OCS0311U00layDupSetHangmogArgs(String setPart, String hangmogCode, String setCode, String setValueHangmogCode)
        {
            this._setPart = setPart;
            this._hangmogCode = hangmogCode;
            this._setCode = setCode;
            this._setValueHangmogCode = setValueHangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00layDupSetHangmogRequest();
        }
    }
}