using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00layDupHangmogCodeArgs : IContractArgs
    {
        private String _setPart;
        private String _hangmogCode;

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

        public OCS0311U00layDupHangmogCodeArgs() { }

        public OCS0311U00layDupHangmogCodeArgs(String setPart, String hangmogCode)
        {
            this._setPart = setPart;
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00layDupHangmogCodeRequest();
        }
    }
}