using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class CboDoctorGradeArgs : IContractArgs
    {
        private String _codeType;
        private String _hospCode;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public CboDoctorGradeArgs() { }

        public CboDoctorGradeArgs(String codeType, String hospCode)
        {
            this._codeType = codeType;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CboDoctorGradeRequest();
        }
    }
}