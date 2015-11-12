using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class HOTCODEMASTERSaveOCS0103Args : IContractArgs
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

        public HOTCODEMASTERSaveOCS0103Args() { }

        public HOTCODEMASTERSaveOCS0103Args(String hospCode, String userId)
        {
            this._hospCode = hospCode;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.HOTCODEMASTERSaveOCS0103Request();
        }
    }
}