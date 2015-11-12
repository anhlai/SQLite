using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02AutoConfirmCheckedArgs : IContractArgs
    {
        private String _codeType;
        private String _jangbiCode;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String JangbiCode
        {
            get { return this._jangbiCode; }
            set { this._jangbiCode = value; }
        }

        public CPL3020U02AutoConfirmCheckedArgs() { }

        public CPL3020U02AutoConfirmCheckedArgs(String codeType, String jangbiCode)
        {
            this._codeType = codeType;
            this._jangbiCode = jangbiCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02AutoConfirmCheckedRequest();
        }
    }
}