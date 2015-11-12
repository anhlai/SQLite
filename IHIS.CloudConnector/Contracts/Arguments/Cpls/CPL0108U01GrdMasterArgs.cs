using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U01GrdMasterArgs : IContractArgs
    {
        private String _codeType;
        private String _codeTypeName;
        private String _hospCode;

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

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public CPL0108U01GrdMasterArgs() { }

        public CPL0108U01GrdMasterArgs(String codeType, String codeTypeName, String hospCode)
        {
            this._codeType = codeType;
            this._codeTypeName = codeTypeName;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U01GrdMasterRequest();
        }
    }
}