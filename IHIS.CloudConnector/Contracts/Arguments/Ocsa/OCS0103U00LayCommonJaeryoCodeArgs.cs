using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00LayCommonJaeryoCodeArgs : IContractArgs
    {
        private String _jaeryoCode;
        private String _hospCode;

        public String JaeryoCode
        {
            get { return this._jaeryoCode; }
            set { this._jaeryoCode = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00LayCommonJaeryoCodeArgs() { }

        public OCS0103U00LayCommonJaeryoCodeArgs(String jaeryoCode, String hospCode)
        {
            this._jaeryoCode = jaeryoCode;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00LayCommonJaeryoCodeRequest();
        }
    }
}