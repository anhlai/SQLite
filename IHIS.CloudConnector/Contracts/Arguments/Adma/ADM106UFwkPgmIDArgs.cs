using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM106UFwkPgmIDArgs : IContractArgs
    {
        private String _pgmId;

        public String PgmId
        {
            get { return this._pgmId; }
            set { this._pgmId = value; }
        }

        public ADM106UFwkPgmIDArgs() { }

        public ADM106UFwkPgmIDArgs(String pgmId)
        {
            this._pgmId = pgmId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM106UFwkPgmIDRequest();
        }
    }
}