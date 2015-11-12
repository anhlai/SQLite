using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00FwkDoctorArgs : IContractArgs
    {
        private String _find1;
        private String _hospCode;

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0270U00FwkDoctorArgs() { }

        public BAS0270U00FwkDoctorArgs(String find1, String hospCode)
        {
            this._find1 = find1;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00FwkDoctorRequest();
        }
    }
}