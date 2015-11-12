using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0101U00grdMasterArgs : IContractArgs
    {
        private String _codeType;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public BAS0101U00grdMasterArgs() { }

        public BAS0101U00grdMasterArgs(String codeType)
        {
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0101U00grdMasterRequest();
        }
    }
}