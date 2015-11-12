using System;
using IHIS.CloudConnector.Contracts.Models.Schs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    public class SCH0109U01GrdMasterArgs : IContractArgs
    {
        private String _codeType;
        private String _codeTypeName;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String CodeTypeName
        {
            get { return this._codeTypeName; }
            set { this._codeTypeName = value; }
        }

        public SCH0109U01GrdMasterArgs() { }

        public SCH0109U01GrdMasterArgs(String codeType, String codeTypeName)
        {
            this._codeType = codeType;
            this._codeTypeName = codeTypeName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.SCH0109U01GrdMasterRequest();
        }
    }
}