using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM104UFindBoxArgs : IContractArgs
    {
        private String _controlName;
        private String _hospCode;

        public String ControlName
        {
            get { return this._controlName; }
            set { this._controlName = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM104UFindBoxArgs() { }

        public ADM104UFindBoxArgs(String controlName, String hospCode)
        {
            this._controlName = controlName;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM104UFindBoxRequest();
        }
    }
}