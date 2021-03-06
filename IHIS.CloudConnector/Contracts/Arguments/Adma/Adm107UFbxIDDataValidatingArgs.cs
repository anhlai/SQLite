using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class Adm107UFbxIDDataValidatingArgs : IContractArgs
    {
        private String _userId;
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public Adm107UFbxIDDataValidatingArgs() { }

        public Adm107UFbxIDDataValidatingArgs(String userId, String hospCode)
        {
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Adm107UFbxIDDataValidatingRequest();
        }
    }
}