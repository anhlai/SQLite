using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0203U00GetOCSCOMUserNameArgs : IContractArgs
    {
        private String _hospCode;
        private String _userId;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public OCS0203U00GetOCSCOMUserNameArgs() { }

        public OCS0203U00GetOCSCOMUserNameArgs(String hospCode, String userId)
        {
            this._hospCode = hospCode;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0203U00GetOCSCOMUserNameRequest();
        }
    }
}