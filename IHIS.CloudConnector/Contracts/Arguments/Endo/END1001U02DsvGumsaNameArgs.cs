using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02DsvGumsaNameArgs : IContractArgs
    {
        private String _code;
        private String _hospCode;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public END1001U02DsvGumsaNameArgs() { }

        public END1001U02DsvGumsaNameArgs(String code, String hospCode)
        {
            this._code = code;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02DsvGumsaNameRequest();
        }
    }
}