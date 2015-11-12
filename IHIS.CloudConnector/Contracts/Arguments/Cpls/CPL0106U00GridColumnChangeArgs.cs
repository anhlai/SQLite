using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0106U00GridColumnChangeArgs : IContractArgs
    {
        private String _code;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public CPL0106U00GridColumnChangeArgs() { }

        public CPL0106U00GridColumnChangeArgs(String code)
        {
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0106U00GridColumnChangeRequest();
        }
    }
}