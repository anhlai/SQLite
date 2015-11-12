using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U09PrefectureCodeArgs : IContractArgs
    {
        private String _codeType;
        private String _find1;

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

        public CLIS2015U09PrefectureCodeArgs() { }

        public CLIS2015U09PrefectureCodeArgs(String codeType, String find1)
        {
            this._codeType = codeType;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U09PrefectureCodeRequest();
        }
    }
}