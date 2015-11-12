using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class AdmLoginFormCheckLoginUserArgs : IContractArgs
    {
        private String _user;
        private String _password;

        public String User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        public String Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        public AdmLoginFormCheckLoginUserArgs() { }

        public AdmLoginFormCheckLoginUserArgs(String user, String password)
        {
            this._user = user;
            this._password = password;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.AdmLoginFormCheckLoginUserRequest();
        }
    }
}