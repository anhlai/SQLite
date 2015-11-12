using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0001U00FbxDodobuHyeunFindClickArgs : IContractArgs
    {
        private String _codeType;
        private String _find1;
        private String _hospCode;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0001U00FbxDodobuHyeunFindClickArgs() { }

        public BAS0001U00FbxDodobuHyeunFindClickArgs(String codeType, String find1, String hospCode)
        {
            this._codeType = codeType;
            this._find1 = find1;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0001U00FbxDodobuHyeunFindClickRequest();
        }
    }
}