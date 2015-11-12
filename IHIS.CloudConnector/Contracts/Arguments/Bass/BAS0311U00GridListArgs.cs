using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0311U00GridListArgs : IContractArgs
    {
        private String _fHospCode;
        private String _fSgCode;

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public String FSgCode
        {
            get { return this._fSgCode; }
            set { this._fSgCode = value; }
        }

        public BAS0311U00GridListArgs() { }

        public BAS0311U00GridListArgs(String fHospCode, String fSgCode)
        {
            this._fHospCode = fHospCode;
            this._fSgCode = fSgCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0311U00GridListRequest();
        }
    }
}