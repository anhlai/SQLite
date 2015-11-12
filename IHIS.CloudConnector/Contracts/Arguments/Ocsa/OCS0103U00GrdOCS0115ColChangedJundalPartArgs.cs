using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GrdOCS0115ColChangedJundalPartArgs : IContractArgs
    {
        private String _gwa;
        private String _hospCode;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00GrdOCS0115ColChangedJundalPartArgs() { }

        public OCS0103U00GrdOCS0115ColChangedJundalPartArgs(String gwa, String hospCode)
        {
            this._gwa = gwa;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GrdOCS0115ColChangedJundalPartRequest();
        }
    }
}