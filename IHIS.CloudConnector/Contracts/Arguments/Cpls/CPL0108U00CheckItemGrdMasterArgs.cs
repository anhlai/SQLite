using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U00CheckItemGrdMasterArgs : IContractArgs
    {
        private String _codeType;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public CPL0108U00CheckItemGrdMasterArgs() { }

        public CPL0108U00CheckItemGrdMasterArgs(String codeType)
        {
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U00CheckItemGrdMasterRequest();
        }
    }
}