using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0203U00GetOCSCOMUserIDArgs : IContractArgs
    {
        private String _userGubun;
        private String _userId;

        public String UserGubun
        {
            get { return this._userGubun; }
            set { this._userGubun = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public OCS0203U00GetOCSCOMUserIDArgs() { }

        public OCS0203U00GetOCSCOMUserIDArgs(String userGubun, String userId)
        {
            this._userGubun = userGubun;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0203U00GetOCSCOMUserIDRequest();
        }
    }
}