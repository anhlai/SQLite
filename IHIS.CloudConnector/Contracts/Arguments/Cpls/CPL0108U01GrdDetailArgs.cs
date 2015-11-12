using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U01GrdDetailArgs : IContractArgs
    {
        private String _codeType;
        private String _hospCode;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public CPL0108U01GrdDetailArgs() { }

        public CPL0108U01GrdDetailArgs(String codeType, String hospCode)
        {
            this._codeType = codeType;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U01GrdDetailRequest();
        }
    }
}