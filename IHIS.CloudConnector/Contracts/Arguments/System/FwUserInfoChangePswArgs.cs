using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class FwUserInfoChangePswArgs : IContractArgs
    {
        private String _userId;
        private String _oldPassword;
        private String _newPassword;
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String OldPassword
        {
            get { return this._oldPassword; }
            set { this._oldPassword = value; }
        }

        public String NewPassword
        {
            get { return this._newPassword; }
            set { this._newPassword = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public FwUserInfoChangePswArgs() { }

        public FwUserInfoChangePswArgs(String userId, String oldPassword, String newPassword, String hospCode)
        {
            this._userId = userId;
            this._oldPassword = oldPassword;
            this._newPassword = newPassword;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.FwUserInfoChangePswRequest();
        }
    }
}