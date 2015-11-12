using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U00GrdMasterArgs : IContractArgs
    {
        private String _codeTypeName;

        public String CodeTypeName
        {
            get { return this._codeTypeName; }
            set { this._codeTypeName = value; }
        }

        public CPL0108U00GrdMasterArgs() { }

        public CPL0108U00GrdMasterArgs(String codeTypeName)
        {
            this._codeTypeName = codeTypeName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U00GrdMasterRequest();
        }
    }
}