using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class FwEMRHelperExecuteEMRArgs : IContractArgs
    {
        private String _userId;
        private String _gwa;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public FwEMRHelperExecuteEMRArgs() { }

        public FwEMRHelperExecuteEMRArgs(String userId, String gwa)
        {
            this._userId = userId;
            this._gwa = gwa;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.FwEMRHelperExecuteEMRRequest();
        }
    }
}