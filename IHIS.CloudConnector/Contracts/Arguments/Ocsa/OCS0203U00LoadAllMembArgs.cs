using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0203U00LoadAllMembArgs : IContractArgs
    {
        private String _hospCode;
        private String _gwa;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public OCS0203U00LoadAllMembArgs() { }

        public OCS0203U00LoadAllMembArgs(String hospCode, String gwa)
        {
            this._hospCode = hospCode;
            this._gwa = gwa;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0203U00LoadAllMembRequest();
        }
    }
}