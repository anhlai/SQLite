using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class Adm107UFbxSysIDDataValidatingArgs : IContractArgs
    {
        private String _userId;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public Adm107UFbxSysIDDataValidatingArgs() { }

        public Adm107UFbxSysIDDataValidatingArgs(String userId)
        {
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Adm107UFbxSysIDDataValidatingRequest();
        }
    }
}