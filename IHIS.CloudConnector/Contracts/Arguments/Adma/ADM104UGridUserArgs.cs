using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM104UGridUserArgs : IContractArgs
    {
        private String _userGroup;
        private String _searchWord;
        private String _userGubun;
        private String _hospCode;

        public String UserGroup
        {
            get { return this._userGroup; }
            set { this._userGroup = value; }
        }

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
        }

        public String UserGubun
        {
            get { return this._userGubun; }
            set { this._userGubun = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM104UGridUserArgs() { }

        public ADM104UGridUserArgs(String userGroup, String searchWord, String userGubun, String hospCode)
        {
            this._userGroup = userGroup;
            this._searchWord = searchWord;
            this._userGubun = userGubun;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM104UGridUserRequest();
        }
    }
}